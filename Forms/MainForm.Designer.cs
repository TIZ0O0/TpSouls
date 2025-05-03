namespace TpSouls.Forms
{
    partial class MainForm
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
            this.OpenTMButton = new System.Windows.Forms.Button();
            this.OpenVCButton = new System.Windows.Forms.Button();
            this.SelectProcButton = new System.Windows.Forms.Button();
            this.ProcName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenTMButton
            // 
            this.OpenTMButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.OpenTMButton.Location = new System.Drawing.Point(45, 106);
            this.OpenTMButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenTMButton.Name = "OpenTMButton";
            this.OpenTMButton.Size = new System.Drawing.Size(114, 63);
            this.OpenTMButton.TabIndex = 15;
            this.OpenTMButton.Text = "Open TpMap";
            this.OpenTMButton.UseVisualStyleBackColor = false;
            this.OpenTMButton.Click += new System.EventHandler(this.OpenTMButton_Click);
            // 
            // OpenVCButton
            // 
            this.OpenVCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.OpenVCButton.Location = new System.Drawing.Point(200, 106);
            this.OpenVCButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenVCButton.Name = "OpenVCButton";
            this.OpenVCButton.Size = new System.Drawing.Size(114, 63);
            this.OpenVCButton.TabIndex = 16;
            this.OpenVCButton.Text = "Open VarChanger";
            this.OpenVCButton.UseVisualStyleBackColor = false;
            this.OpenVCButton.Click += new System.EventHandler(this.OpenVCButton_Click);
            // 
            // SelectProcButton
            // 
            this.SelectProcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.SelectProcButton.Location = new System.Drawing.Point(11, 45);
            this.SelectProcButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectProcButton.Name = "SelectProcButton";
            this.SelectProcButton.Size = new System.Drawing.Size(70, 40);
            this.SelectProcButton.TabIndex = 17;
            this.SelectProcButton.Text = "Select Process";
            this.SelectProcButton.UseVisualStyleBackColor = false;
            this.SelectProcButton.Click += new System.EventHandler(this.SelectProcButton_Click);
            // 
            // ProcName
            // 
            this.ProcName.AutoSize = true;
            this.ProcName.Location = new System.Drawing.Point(9, 7);
            this.ProcName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProcName.Name = "ProcName";
            this.ProcName.Size = new System.Drawing.Size(105, 13);
            this.ProcName.TabIndex = 25;
            this.ProcName.Text = "ProcessName: None";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 304);
            this.Controls.Add(this.ProcName);
            this.Controls.Add(this.SelectProcButton);
            this.Controls.Add(this.OpenVCButton);
            this.Controls.Add(this.OpenTMButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenTMButton;
        private System.Windows.Forms.Button OpenVCButton;
        private System.Windows.Forms.Button SelectProcButton;
        private System.Windows.Forms.Label ProcName;
    }
}