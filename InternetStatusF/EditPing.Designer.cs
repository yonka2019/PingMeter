namespace InternetStatusF
{
    partial class EditPing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPing));
            this.PingTB = new System.Windows.Forms.TextBox();
            this.UpdateB = new System.Windows.Forms.Button();
            this.ResetB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetB2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetB3 = new System.Windows.Forms.Button();
            this.TimeoutUD = new System.Windows.Forms.NumericUpDown();
            this.UpdateUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateUD)).BeginInit();
            this.SuspendLayout();
            // 
            // PingTB
            // 
            this.PingTB.BackColor = System.Drawing.SystemColors.Window;
            this.PingTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingTB.Location = new System.Drawing.Point(199, 22);
            this.PingTB.Name = "PingTB";
            this.PingTB.Size = new System.Drawing.Size(100, 26);
            this.PingTB.TabIndex = 0;
            // 
            // UpdateB
            // 
            this.UpdateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UpdateB.Location = new System.Drawing.Point(167, 124);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(132, 40);
            this.UpdateB.TabIndex = 1;
            this.UpdateB.Text = "Update";
            this.UpdateB.UseVisualStyleBackColor = true;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // ResetB
            // 
            this.ResetB.Image = global::InternetStatusF.Properties.Resources.Reset;
            this.ResetB.Location = new System.Drawing.Point(305, 22);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(26, 26);
            this.ResetB.TabIndex = 2;
            this.ResetB.UseVisualStyleBackColor = true;
            this.ResetB.Click += new System.EventHandler(this.ResetB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(123, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timeout:";
            // 
            // ResetB2
            // 
            this.ResetB2.Image = global::InternetStatusF.Properties.Resources.Reset;
            this.ResetB2.Location = new System.Drawing.Point(305, 54);
            this.ResetB2.Name = "ResetB2";
            this.ResetB2.Size = new System.Drawing.Size(26, 26);
            this.ResetB2.TabIndex = 5;
            this.ResetB2.UseVisualStyleBackColor = true;
            this.ResetB2.Click += new System.EventHandler(this.ResetB2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Update every (ms):";
            // 
            // ResetB3
            // 
            this.ResetB3.Image = global::InternetStatusF.Properties.Resources.Reset;
            this.ResetB3.Location = new System.Drawing.Point(305, 86);
            this.ResetB3.Name = "ResetB3";
            this.ResetB3.Size = new System.Drawing.Size(26, 26);
            this.ResetB3.TabIndex = 8;
            this.ResetB3.UseVisualStyleBackColor = true;
            this.ResetB3.Click += new System.EventHandler(this.ResetB3_Click);
            // 
            // TimeoutUD
            // 
            this.TimeoutUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimeoutUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TimeoutUD.Location = new System.Drawing.Point(199, 54);
            this.TimeoutUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeoutUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TimeoutUD.Name = "TimeoutUD";
            this.TimeoutUD.Size = new System.Drawing.Size(100, 26);
            this.TimeoutUD.TabIndex = 11;
            this.TimeoutUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // UpdateUD
            // 
            this.UpdateUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UpdateUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UpdateUD.Location = new System.Drawing.Point(199, 86);
            this.UpdateUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.UpdateUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpdateUD.Name = "UpdateUD";
            this.UpdateUD.Size = new System.Drawing.Size(100, 26);
            this.UpdateUD.TabIndex = 12;
            this.UpdateUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // EditPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 176);
            this.Controls.Add(this.UpdateUD);
            this.Controls.Add(this.TimeoutUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetB3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetB2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetB);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.PingTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.EditPing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PingTB;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button ResetB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetB3;
        private System.Windows.Forms.NumericUpDown TimeoutUD;
        private System.Windows.Forms.NumericUpDown UpdateUD;
    }
}