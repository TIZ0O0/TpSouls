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

        private VarControl varCtrl1;
        private VarControl varCtrl2;


        public VarChanger(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void VarChanger_Load(object sender, EventArgs e)
        {
            varCtrl1 = new VarControl();
            varCtrl2 = new VarControl();

            VarPanel.Controls.Add(varCtrl1);
            VarPanel.Controls.Add(varCtrl2);
        }

        private void VarChanger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
