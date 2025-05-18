using System;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Windows.Forms;


namespace TpSouls
{
    internal class ProcessButton : Button
    {
        public uint assignedProcID;
        public string assignedProcName;

        private static readonly Color baseBackColor = Color.FromArgb(61, 61, 61);
        private static readonly Color pressedBackColor = Color.FromArgb(77, 77, 77);
        private static readonly Color textColor = SystemColors.ButtonHighlight;

        public ProcessButton(uint procID, string procName) : base()
        {
            this.assignedProcID = procID;
            this.assignedProcName = procName;
            this.Click += new System.EventHandler(ProcessButton_Click);
            this.BackColor = baseBackColor;
            this.ForeColor = textColor;
            this.FlatStyle = FlatStyle.Popup;
            Text = assignedProcName;            
            Dock = DockStyle.Top;
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            SelectProcess(this);
        }

        private static void SelectProcess(ProcessButton pb)
        {
            if (TpSoulsLogic.selectedProcButton != null)
                TpSoulsLogic.selectedProcButton.BackColor = baseBackColor;

            TpSoulsLogic.selectedProcButton = pb;

            TpSoulsLogic.selectedProcButton.BackColor = pressedBackColor;
        }
    }
}
