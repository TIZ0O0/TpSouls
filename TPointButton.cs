
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TpSouls
{
    internal class TPointButton : Button
    {
        public TPoint assignedTPoint;

        private static readonly Color baseBackColor = Color.FromArgb(207, 212, 212);
        private static readonly Color pressedBackColor = Color.FromArgb(176, 176, 176);

        public TPointButton(TPoint assignedTPoint) : base()
        {         
            this.assignedTPoint = assignedTPoint;
            this.Click += new System.EventHandler(TPointButton_Click);
            Text = assignedTPoint.name;
            BackColor = baseBackColor;
            Dock = DockStyle.Top;
        }

        private void TPointButton_Click(object sender, EventArgs e)
        {            
            SelectTPoint(this);
        }

        private static void SelectTPoint(TPointButton tpButton)
        {
            if (TpSoulsLogic.selectedTPbutton != null)
                TpSoulsLogic.selectedTPbutton.BackColor = baseBackColor;

            TpSoulsLogic.selectedTPbutton = tpButton;

            TpSoulsLogic.selectedTPbutton.BackColor = pressedBackColor;
        }
    }
}
