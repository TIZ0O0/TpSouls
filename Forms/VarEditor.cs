using System;
using System.Windows.Forms;

namespace TpSouls.Forms
{
    public partial class VarEditor : Form
    {
        private readonly VarList varList;

        public VarEditor(VarList varList)
        {
            InitializeComponent();
            this.varList = varList;
        }   
        
        public void SetValue(string value, string type)
        {
            this.Value.Text = value;
            this.ValueType.Text = "ValueType: " + type;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            varList.Enabled = true;
            this.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MainLogic.ErrorType error = MainLogic.SetValue(
                MainLogic.selectedVarCtrl.VarOffset, 
                MainLogic.selectedVarCtrl.VarType, 
                this.Value.Text);

            switch (error)
            {
                case MainLogic.ErrorType.None:
                    varList.Enabled = true;
                    this.Hide();
                    break;                                      
                    
                case MainLogic.ErrorType.UnknownType:
                    MessageBox.Show("Unknwon value type!", "ErrorMessage", MessageBoxButtons.OK);
                    break;

                case MainLogic.ErrorType.FailedToWriteMemory:
                    MessageBox.Show("Failed to change value! (Use right value format or check pointers)", "ErrorMessage", MessageBoxButtons.OK);
                    break;

                default:
                    break;
            }            
        }
    }
}
