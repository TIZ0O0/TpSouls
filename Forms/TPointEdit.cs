using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpSouls
{
    public partial class TPointEdit : Form
    {
        public EditorMode mode;

        private readonly TpMap tpMap;

        public TPointEdit(TpMap tpMap)
        {
            InitializeComponent();
            this.tpMap = tpMap;
        }

        public void CallEditor(EditorMode mode)
        {
            this.Show();
            this.mode = mode;

            if (mode == EditorMode.Edit)
            {
                NameBox.Text = TpSoulsLogic.selectedTPbutton.assignedTPoint.name;
                PosXBox.Text = TpSoulsLogic.selectedTPbutton.assignedTPoint.posX.ToString();
                PosYBox.Text = TpSoulsLogic.selectedTPbutton.assignedTPoint.posY.ToString();
                PosZBox.Text = TpSoulsLogic.selectedTPbutton.assignedTPoint.posZ.ToString();
            }
        }

        private void RefreshBoxes()
        {
            NameBox.Text = "";
            PosXBox.Text = "";
            PosYBox.Text = "";
            PosZBox.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            tpMap.Enabled = true;

            this.Hide();
            RefreshBoxes();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            float posX;
            float posY;
            float posZ;

            try
            {
                posX = float.Parse(PosXBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                posY = float.Parse(PosYBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                posZ = float.Parse(PosZBox.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong position format!", "ErrorMessage", MessageBoxButtons.OK);
                return;
                throw;
            }

            switch (mode)
            {
                case EditorMode.AddNew:
                    TPoint newTP = new TPoint(NameBox.Text, posX, posY, posZ);
                    TpSoulsLogic.selectedTPoints.Add(newTP);
                    tpMap.TPointsPannel.Controls.Add(new TPointButton(newTP));
                    break;

                case EditorMode.Edit:
                    TpSoulsLogic.selectedTPbutton.assignedTPoint.name = NameBox.Text;
                    TpSoulsLogic.selectedTPbutton.Text = NameBox.Text;
                    TpSoulsLogic.selectedTPbutton.assignedTPoint.posX = posX;
                    TpSoulsLogic.selectedTPbutton.assignedTPoint.posY = posY;
                    TpSoulsLogic.selectedTPbutton.assignedTPoint.posZ = posZ;
                    break;

                default:
                    break;
            }

            tpMap.Enabled = true;

            this.Hide();
            RefreshBoxes();
        }

        public enum EditorMode 
        { 
            AddNew,
            Edit
        }
    }
}
