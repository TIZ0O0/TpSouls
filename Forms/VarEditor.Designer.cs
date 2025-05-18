namespace TpSouls.Forms
{
    partial class VarEditor
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
            this.Value = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancButton = new System.Windows.Forms.Button();
            this.ValueType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Value.Location = new System.Drawing.Point(71, 66);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(252, 22);
            this.Value.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OkButton.Location = new System.Drawing.Point(41, 123);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(114, 55);
            this.OkButton.TabIndex = 16;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancButton
            // 
            this.CancButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CancButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancButton.Location = new System.Drawing.Point(243, 123);
            this.CancButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(114, 55);
            this.CancButton.TabIndex = 17;
            this.CancButton.Text = "Cancel";
            this.CancButton.UseVisualStyleBackColor = false;
            this.CancButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ValueType
            // 
            this.ValueType.AutoSize = true;
            this.ValueType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValueType.Location = new System.Drawing.Point(133, 33);
            this.ValueType.Name = "ValueType";
            this.ValueType.Size = new System.Drawing.Size(113, 16);
            this.ValueType.TabIndex = 18;
            this.ValueType.Text = "ValueType: None";
            // 
            // VarEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(398, 199);
            this.ControlBox = false;
            this.Controls.Add(this.ValueType);
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.Value);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VarEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VarEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancButton;
        private System.Windows.Forms.Label ValueType;
    }
}