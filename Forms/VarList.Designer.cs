namespace TpSouls
{
    partial class VarList
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
            this.VarPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProcName = new System.Windows.Forms.Label();
            this.ValueRefresh = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // VarPanel
            // 
            this.VarPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.VarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.VarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VarPanel.Location = new System.Drawing.Point(148, 43);
            this.VarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.VarPanel.Name = "VarPanel";
            this.VarPanel.Size = new System.Drawing.Size(341, 361);
            this.VarPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(15, 368);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 42);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProcName
            // 
            this.ProcName.AutoSize = true;
            this.ProcName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProcName.Location = new System.Drawing.Point(12, 9);
            this.ProcName.Name = "ProcName";
            this.ProcName.Size = new System.Drawing.Size(133, 16);
            this.ProcName.TabIndex = 27;
            this.ProcName.Text = "ProcessName: None";
            // 
            // ValueRefresh
            // 
            this.ValueRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ValueRefresh_DoWork);
            // 
            // VarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(512, 421);
            this.Controls.Add(this.ProcName);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.VarPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VarList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VarChanger_FormClosing);
            this.Load += new System.EventHandler(this.VarList_Load);
            this.Shown += new System.EventHandler(this.VarList_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel VarPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ProcName;
        private System.ComponentModel.BackgroundWorker ValueRefresh;
    }
}