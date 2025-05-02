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
        private TpMap tMap;
        private VarChanger varChanger;

        public MainForm()
        {
            InitializeComponent();
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
            tMap.Hide();
            varChanger.Hide();
        }

        private void OpenVCButton_Click(object sender, EventArgs e)
        {
            varChanger.Show();
            this.Hide();
        }
    }
}
