using System;
using System.ComponentModel;
using System.Windows.Forms;
using TpSouls.Forms;
using TpSouls.UI_Elements;

namespace TpSouls
{
    public partial class VarList : Form
    {
        private readonly MainForm mainForm;
        private VarEditor varEditor;

        public VarList(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        public void SetProcessName(string name)
        {
            this.ProcName.Text = "ProcessName: " + name;
        }

        public void CallVarEditor(string value, string type)
        {
            varEditor.SetValue(value, type);
            varEditor.Show();
            this.Enabled = false;
        }

        private void VarChanger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void VarList_Load(object sender, EventArgs e)
        {
            varEditor = new VarEditor(this);
            varEditor.Hide();
        }

        private void ValueRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                foreach (VarControl varCtrl in this.VarPanel.Controls)
                {
                    varCtrl.Invoke((MethodInvoker)(() =>
                    {
                        varCtrl.VarValue = MainLogic.GetValue(varCtrl.VarOffset, varCtrl.VarType);
                    }));
                }

                System.Threading.Thread.Sleep(200);
            }
        }

        private void VarList_Shown(object sender, EventArgs e)
        {
            ValueRefresh.RunWorkerAsync();
        }
    }
}
