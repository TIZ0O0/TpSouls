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

        private static readonly Color baseBackColor = Color.FromArgb(207, 212, 212);
        private static readonly Color pressedBackColor = Color.FromArgb(176, 176, 176);

        public ProcessButton(uint procID, string procName) : base()
        {
            this.assignedProcID = procID;
            this.assignedProcName = procName;
            this.Click += new System.EventHandler(ProcessButton_Click);
            this.BackColor = baseBackColor;
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
