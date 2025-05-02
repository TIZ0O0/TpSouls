namespace TpSouls
{
    partial class TPointEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PosXBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PosYBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PosZBox = new System.Windows.Forms.TextBox();
            this.CancButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.SaveButton.Location = new System.Drawing.Point(33, 123);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 63);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(69, 7);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(194, 20);
            this.NameBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "PosX";
            // 
            // PosXBox
            // 
            this.PosXBox.Location = new System.Drawing.Point(69, 36);
            this.PosXBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PosXBox.Name = "PosXBox";
            this.PosXBox.Size = new System.Drawing.Size(194, 20);
            this.PosXBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "PosY";
            // 
            // PosYBox
            // 
            this.PosYBox.Location = new System.Drawing.Point(69, 63);
            this.PosYBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PosYBox.Name = "PosYBox";
            this.PosYBox.Size = new System.Drawing.Size(194, 20);
            this.PosYBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "PosZ";
            // 
            // PosZBox
            // 
            this.PosZBox.Location = new System.Drawing.Point(69, 89);
            this.PosZBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PosZBox.Name = "PosZBox";
            this.PosZBox.Size = new System.Drawing.Size(194, 20);
            this.PosZBox.TabIndex = 24;
            // 
            // CancButton
            // 
            this.CancButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.CancButton.Location = new System.Drawing.Point(170, 123);
            this.CancButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(114, 63);
            this.CancButton.TabIndex = 26;
            this.CancButton.Text = "Cancel";
            this.CancButton.UseVisualStyleBackColor = false;
            this.CancButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TPointEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 198);
            this.ControlBox = false;
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PosZBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PosYBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PosXBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TPointEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPoint_Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PosXBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PosYBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PosZBox;
        private System.Windows.Forms.Button CancButton;
    }
}