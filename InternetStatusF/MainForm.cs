using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace InternetStatusF
{
    public partial class MainForm : Form
    {
        private readonly double[] pingArray = new double[60];
        private bool working = false;
        private readonly ToolTip tip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTitle();
            tip.SetToolTip(SettingsB, "Settings");
            PPB.PerformClick();
        }

        internal void UpdateTitle() =>
            PingChart.Titles["HostName"].Text = $"Host: {Properties.Settings.Default.PingTo}";

        private void Pinger()
        {
            Ping ping = new Ping();
            while (working)
            {
                try
                {
                    PingReply reply = ping.Send(Properties.Settings.Default.PingTo, Properties.Settings.Default.Timeout);
                    pingArray[pingArray.Length - 1] = reply.RoundtripTime;
                    Array.Copy(pingArray, 1, pingArray, 0, pingArray.Length - 1);

                    Invoke((MethodInvoker)delegate
                    {
                        //STATUS LABEL
                        if (reply.Status == IPStatus.Success)
                            StatusL.ForeColor = Color.Green;
                        else
                            StatusL.ForeColor = Color.Red;
                        StatusL.Text = reply.Status.ToString();
                        //PING LABEL
                        if (reply.RoundtripTime > 149 || reply.RoundtripTime == 0)
                            PingL.ForeColor = Color.Red;
                        else if (reply.RoundtripTime > 89 && reply.RoundtripTime < 150)
                            PingL.ForeColor = Color.Orange;
                        else
                            PingL.ForeColor = Color.Green;
                        if (reply.Status == IPStatus.TimedOut)
                            PingL.Text = $"{Properties.Settings.Default.Timeout}+ ms";
                        else
                            PingL.Text = $"{reply.RoundtripTime} ms";

                        UpdatePingChart();
                    });
                    Thread.Sleep(Properties.Settings.Default.UpdateMS);
                }
                catch
                {
                    Invoke((MethodInvoker)delegate
                    {
                        StatusL.ForeColor = Color.Red;
                        StatusL.Text = "Unknow Host";
                        PingL.ForeColor = Color.Red;
                        PingL.Text = "0";
                    });
                }
            }
        }

        private void UpdatePingChart()
        {
            PingChart.Series["Ping (ms)"].Points.Clear();
            for (int i = 0; i < pingArray.Length - 1; i++)
                PingChart.Series["Ping (ms)"].Points.AddY(pingArray[i]);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            working = false;
            Environment.Exit(0);
        }

        private void CleanB_Click(object sender, EventArgs e)
        {
            Array.Clear(pingArray, 0, pingArray.Length);
            PingChart.Series["Ping (ms)"].Points.Clear();
        }

        private void SettingsB_Click(object sender, EventArgs e)
        {
            EditPing form = new EditPing(this);
            form.ShowDialog();
        }

        private void PPB_Click(object sender, EventArgs e)
        {
            working = !working;
            if (working)
            {
                PPB.Image = Properties.Resources.Pause;
                tip.SetToolTip(PPB, "Pause");
                new Thread(Pinger).Start();
            }
            else
            {
                PPB.Image = Properties.Resources.Play;
                tip.SetToolTip(PPB, "Play");
            }

        }
    }
}
