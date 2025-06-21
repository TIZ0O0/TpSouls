using System;
using System.Windows.Forms;

namespace TpSouls.Forms
{
    public partial class MainForm : Form
    {
        public VarList varList;
        public ProcessesPannel procPanel;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetProcessName(string name)
        {
            this.ProcName.Text = "ProcessName: " + name;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            varList = new VarList(this);
            procPanel = new ProcessesPannel(this);
            varList.Hide();
            procPanel.Hide();
        }

        private void OpenVCButton_Click(object sender, EventArgs e)
        {
            varList.Show();
            this.Hide();
        }

        private void SelectProcButton_Click(object sender, EventArgs e)
        {
            procPanel.CallProcessesPannel();
            this.Enabled = false;
        }
    }
}
