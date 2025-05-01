namespace TpSouls
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.TPointsPannel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.TeleportButton = new System.Windows.Forms.Button();
            this.SelectProcButton = new System.Windows.Forms.Button();
            this.ProcName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.SaveButton.Location = new System.Drawing.Point(149, 395);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 22);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.LoadButton.Location = new System.Drawing.Point(253, 395);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(98, 22);
            this.LoadButton.TabIndex = 10;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(26, 31);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(105, 16);
            this.FileName.TabIndex = 14;
            this.FileName.Text = "FileName: None";
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.NewButton.Location = new System.Drawing.Point(405, 31);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(73, 69);
            this.NewButton.TabIndex = 15;
            this.NewButton.Text = "New TpMap";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // TPointsPannel
            // 
            this.TPointsPannel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.TPointsPannel.AutoScroll = true;
            this.TPointsPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPointsPannel.Location = new System.Drawing.Point(29, 63);
            this.TPointsPannel.Name = "TPointsPannel";
            this.TPointsPannel.Size = new System.Drawing.Size(322, 311);
            this.TPointsPannel.TabIndex = 18;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.AddButton.Location = new System.Drawing.Point(405, 106);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(73, 69);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Add TPoint";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditButton.Location = new System.Drawing.Point(405, 181);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(73, 69);
            this.EditButton.TabIndex = 20;
            this.EditButton.Text = "Edit TPoint";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.DelButton.Location = new System.Drawing.Point(405, 256);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(73, 69);
            this.DelButton.TabIndex = 21;
            this.DelButton.Text = "Delete TPoint";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // TeleportButton
            // 
            this.TeleportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.TeleportButton.Location = new System.Drawing.Point(405, 331);
            this.TeleportButton.Name = "TeleportButton";
            this.TeleportButton.Size = new System.Drawing.Size(73, 69);
            this.TeleportButton.TabIndex = 22;
            this.TeleportButton.Text = "Teleport";
            this.TeleportButton.UseVisualStyleBackColor = false;
            this.TeleportButton.Click += new System.EventHandler(this.TeleportButton_Click);
            // 
            // SelectProcButton
            // 
            this.SelectProcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.SelectProcButton.Location = new System.Drawing.Point(29, 395);
            this.SelectProcButton.Name = "SelectProcButton";
            this.SelectProcButton.Size = new System.Drawing.Size(98, 22);
            this.SelectProcButton.TabIndex = 23;
            this.SelectProcButton.Text = "Select Proc";
            this.SelectProcButton.UseVisualStyleBackColor = false;
            this.SelectProcButton.Click += new System.EventHandler(this.SelectProcButton_Click);
            // 
            // ProcName
            // 
            this.ProcName.AutoSize = true;
            this.ProcName.Location = new System.Drawing.Point(26, 9);
            this.ProcName.Name = "ProcName";
            this.ProcName.Size = new System.Drawing.Size(133, 16);
            this.ProcName.TabIndex = 24;
            this.ProcName.Text = "ProcessName: None";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.ProcName);
            this.Controls.Add(this.SelectProcButton);
            this.Controls.Add(this.TeleportButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TPointsPannel);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tp_Souls";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button NewButton;
        public System.Windows.Forms.Panel TPointsPannel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button TeleportButton;
        private System.Windows.Forms.Button SelectProcButton;
        private System.Windows.Forms.Label ProcName;
    }
}

