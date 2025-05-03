using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpSouls.UI_Elements;

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
            TpSoulsLogic.ErrorType error = TpSoulsLogic.SetValue(
                TpSoulsLogic.selectedVarCtrl.VarOffset, 
                TpSoulsLogic.selectedVarCtrl.VarType, 
                this.Value.Text);

            switch (error)
            {
                case TpSoulsLogic.ErrorType.None:
                    varList.Enabled = true;
                    this.Hide();
                    break;                                      
                    
                case TpSoulsLogic.ErrorType.UnknownType:
                    MessageBox.Show("Unknwon value type!", "ErrorMessage", MessageBoxButtons.OK);
                    break;

                case TpSoulsLogic.ErrorType.FailedToWriteMemory:
                    MessageBox.Show("Failed to change value! (Use right value format or check offsets)", "ErrorMessage", MessageBoxButtons.OK);
                    break;

                default:
                    break;
            }            
        }
    }
}
