using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpSouls.Forms;
using TpSouls.UI_Elements;

namespace TpSouls
{
    public partial class VarChanger : Form
    {
        private MainForm mainForm;      

        public VarChanger(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        public void SetProcessName(string name)
        {
            this.ProcName.Text = "ProcessName: " + name;
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
    }
}
