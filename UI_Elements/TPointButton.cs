
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TpSouls
{
    internal class TPointButton : Button
    {
        public TPoint assignedTPoint;

        private static readonly Color baseBackColor = Color.FromArgb(61, 61, 61);
        private static readonly Color pressedBackColor = Color.FromArgb(77, 77, 77);
        private static readonly Color textColor = SystemColors.ButtonHighlight;

        public TPointButton(TPoint assignedTPoint) : base()
        {         
            this.assignedTPoint = assignedTPoint;
            this.Click += new System.EventHandler(TPointButton_Click);
            this.FlatStyle = FlatStyle.Popup;
            this.ForeColor = textColor;
            this.Text = assignedTPoint.name;
            this.BackColor = baseBackColor;
            this.Dock = DockStyle.Top;
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
