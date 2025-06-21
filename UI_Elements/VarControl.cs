using System;
using System.Drawing;
using System.Windows.Forms;

namespace TpSouls.UI_Elements
{
    internal class VarControl : UserControl
    {
        public string VarType;
        public string VarOffset;

        private readonly VarList varList;

        private TextBox textBox;
        private Label label;
        private CheckBox checkBox;

        private Color textBoxColor = Color.FromArgb(54, 54, 54);
        private Color checkBoxColor = Color.FromArgb(54, 54, 54);
        private Color controlColor = Color.FromArgb(49, 49, 49);
        private Color textColor = SystemColors.ButtonHighlight;

        public string VarValue
        { 
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public string VarName 
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public bool FreezeValue 
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }

        public VarControl(VarList varList, string varName, string varOffset, string varType)
        {
            this.Size = new Size(190,30);
            this.BackColor = controlColor;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.VarOffset = varOffset;
            this.VarType = varType;
            this.varList = varList;

            textBox = new TextBox();
            
            textBox.Text = "SomeNum";
            textBox.ForeColor = textColor;
            textBox.Size = new Size(135,30);
            textBox.Location = new Point(95,4);
            textBox.BackColor = textBoxColor;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.ReadOnly = true;
            textBox.MouseDoubleClick += TextBox_DoubleClick;

            label = new Label();

            label.Text = varName;
            label.ForeColor = textColor;
            label.Size = new Size(60,20);
            label.Location = new Point(23, 7);

            checkBox = new CheckBox();

            checkBox.BackColor = checkBoxColor;
            checkBox.ForeColor = textColor;
            checkBox.Size = new Size(30,30);
            checkBox.Location = new Point(5,0);
            checkBox.CheckedChanged += CheckBox_CheckedChange;

            this.Controls.Add(textBox);
            this.Controls.Add(label);
            this.Controls.Add(checkBox);            

            this.Dock = DockStyle.Top;
        }     

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            MainLogic.selectedVarCtrl = this;

            varList.CallVarEditor(this.VarValue, this.VarType);
        }

        private void CheckBox_CheckedChange(object sender, EventArgs e)
        {
            bool succes = MainLogic.SetValueFreezeState(VarOffset, VarType, VarValue, checkBox.Checked);
            if (!succes) checkBox.Checked = !checkBox.Checked;
        }
    }
}
