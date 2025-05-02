namespace TpSouls
{
    partial class VarChanger
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
            this.SuspendLayout();
            // 
            // VarPanel
            // 
            this.VarPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.VarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VarPanel.Location = new System.Drawing.Point(30, 12);
            this.VarPanel.Name = "VarPanel";
            this.VarPanel.Size = new System.Drawing.Size(244, 318);
            this.VarPanel.TabIndex = 0;
            // 
            // VarChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 342);
            this.Controls.Add(this.VarPanel);
            this.MaximizeBox = false;
            this.Name = "VarChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VarChanger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VarChanger_FormClosing);
            this.Load += new System.EventHandler(this.VarChanger_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel VarPanel;
    }
}