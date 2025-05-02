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
            this.OpenTMButton.Location = new System.Drawing.Point(60, 130);
            this.OpenTMButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenTMButton.Name = "OpenTMButton";
            this.OpenTMButton.Size = new System.Drawing.Size(152, 78);
            this.OpenTMButton.TabIndex = 15;
            this.OpenTMButton.Text = "Open TpMap";
            this.OpenTMButton.UseVisualStyleBackColor = false;
            this.OpenTMButton.Click += new System.EventHandler(this.OpenTMButton_Click);
            // 
            // OpenVCButton
            // 
            this.OpenVCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.OpenVCButton.Location = new System.Drawing.Point(267, 130);
            this.OpenVCButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenVCButton.Name = "OpenVCButton";
            this.OpenVCButton.Size = new System.Drawing.Size(152, 78);
            this.OpenVCButton.TabIndex = 16;
            this.OpenVCButton.Text = "Open VarChanger";
            this.OpenVCButton.UseVisualStyleBackColor = false;
            this.OpenVCButton.Click += new System.EventHandler(this.OpenVCButton_Click);
            // 
            // SelectProcButton
            // 
            this.SelectProcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.SelectProcButton.Location = new System.Drawing.Point(12, 50);
            this.SelectProcButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectProcButton.Name = "SelectProcButton";
            this.SelectProcButton.Size = new System.Drawing.Size(94, 40);
            this.SelectProcButton.TabIndex = 17;
            this.SelectProcButton.Text = "Select Process";
            this.SelectProcButton.UseVisualStyleBackColor = false;
            this.SelectProcButton.Click += new System.EventHandler(this.SelectProcButton_Click);
            // 
            // ProcName
            // 
            this.ProcName.AutoSize = true;
            this.ProcName.Location = new System.Drawing.Point(12, 9);
            this.ProcName.Name = "ProcName";
            this.ProcName.Size = new System.Drawing.Size(133, 16);
            this.ProcName.TabIndex = 25;
            this.ProcName.Text = "ProcessName: None";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 374);
            this.Controls.Add(this.ProcName);
            this.Controls.Add(this.SelectProcButton);
            this.Controls.Add(this.OpenVCButton);
            this.Controls.Add(this.OpenTMButton);
            this.Margin = new System.Windows.Forms.Padding(4);
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