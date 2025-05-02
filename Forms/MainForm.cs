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
        public VarChanger varChanger;
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
            varChanger = new VarChanger(this);
            procPanel = new ProcessesPannel(this);
            tMap.Hide();
            varChanger.Hide();
            procPanel.Hide();
        }

        private void OpenVCButton_Click(object sender, EventArgs e)
        {
            varChanger.Show();
            this.Hide();
        }

        private void SelectProcButton_Click(object sender, EventArgs e)
        {
            procPanel.CallProcessesPannel();
            this.Enabled = false;
        }
    }
}
