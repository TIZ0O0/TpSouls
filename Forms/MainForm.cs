using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpSouls.Forms
{
    public partial class MainForm : Form
    {
        public TpMap tMap;
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

        private void OpenTMButton_Click(object sender, EventArgs e)
        {
            tMap.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tMap = new TpMap(this);
            varList = new VarList(this);
            procPanel = new ProcessesPannel(this);
            tMap.Hide();
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
