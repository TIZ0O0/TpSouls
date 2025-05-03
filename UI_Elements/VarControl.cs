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

        private static object locker = new object();

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
            this.BorderStyle = BorderStyle.FixedSingle;

            this.VarOffset = varOffset;
            this.VarType = varType;
            this.varList = varList;

            textBox = new TextBox();
            
            textBox.Text = "SomeNum";
            textBox.Size = new Size(135,30);
            textBox.Location = new Point(95,4);
            textBox.ReadOnly = true;
            textBox.MouseDoubleClick += TextBox_DoubleClick;

            label = new Label();

            label.Text = varName;
            label.Size = new Size(60,20);
            label.Location = new Point(23, 7);

            checkBox = new CheckBox();

            checkBox.Size = new Size(30,30);
            checkBox.Location = new Point(5,0);            

            this.Controls.Add(textBox);
            this.Controls.Add(label);
            this.Controls.Add(checkBox);            

            this.Dock = DockStyle.Top;
        }

        public void ChangeVarValue(string value)
        {
            lock (locker)
            {
                VarValue = value;
            }
        }

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            TpSoulsLogic.selectedVarCtrl = this;

            varList.CallVarEditor(this.VarValue, this.VarType);
        }
    }
}
