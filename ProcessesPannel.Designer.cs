namespace TpSouls
{
    partial class ProcessesPannel
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
            this.ProcPannel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcPannel
            // 
            this.ProcPannel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.ProcPannel.AutoScroll = true;
            this.ProcPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcPannel.Location = new System.Drawing.Point(45, 12);
            this.ProcPannel.Name = "ProcPannel";
            this.ProcPannel.Size = new System.Drawing.Size(411, 187);
            this.ProcPannel.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.OkButton.Location = new System.Drawing.Point(74, 216);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 46);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancButton
            // 
            this.CancButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CancButton.Location = new System.Drawing.Point(325, 216);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(98, 46);
            this.CancButton.TabIndex = 3;
            this.CancButton.Text = "Cancel";
            this.CancButton.UseVisualStyleBackColor = false;
            this.CancButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProcessesPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 284);
            this.ControlBox = false;
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ProcPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessesPannel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        public System.Windows.Forms.Panel ProcPannel;
        private System.Windows.Forms.Button CancButton;
    }
}