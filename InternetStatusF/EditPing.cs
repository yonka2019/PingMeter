using System;
using System.Windows.Forms;

namespace InternetStatusF
{
    public partial class EditPing : Form
    {
        private readonly MainForm f;
        public EditPing(MainForm form)
        {
            InitializeComponent();
            f = form;
            ToolTip tip = new ToolTip();
            tip.SetToolTip(ResetB, "Reset");
            tip.SetToolTip(ResetB2, "Reset");
            tip.SetToolTip(ResetB3, "Reset");
        }

        private void EditPing_Load(object sender, EventArgs e)
        {
            PingTB.Text = Properties.Settings.Default.PingTo;
            TimeoutUD.Value = Properties.Settings.Default.Timeout;
            UpdateUD.Value = Properties.Settings.Default.UpdateMS;
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PingTo = PingTB.Text;
            Properties.Settings.Default.Timeout = (int)TimeoutUD.Value;
            Properties.Settings.Default.UpdateMS = (int)UpdateUD.Value;
            Properties.Settings.Default.Save();
            f.UpdateTitle();
        }

        private void ResetB_Click(object sender, EventArgs e) =>
            PingTB.Text = "8.8.8.8";

        private void ResetB2_Click(object sender, EventArgs e) =>
            TimeoutUD.Value = 2000;

        private void ResetB3_Click(object sender, EventArgs e) =>
            UpdateUD.Value = 500;
    }
}
