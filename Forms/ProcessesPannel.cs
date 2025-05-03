using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using TpSouls.Forms;

namespace TpSouls
{
    public partial class ProcessesPannel : Form
    {
        public readonly MainForm mainForm;

        public ProcessesPannel(MainForm mForm)
        {
            InitializeComponent();
            this.mainForm = mForm;
        }

        public void SetAllProcessName(string name)
        {
            mainForm.SetProcessName(name);
            mainForm.tMap.SetProcessName(name);
            mainForm.varList.SetProcessName(name);
        }

        public void CallProcessesPannel()
        {
            this.Show();

            TpSoulsLogic.currentProcs = ProcFinderWinAPI.GetProcesses();

            ProcPannel.Controls.Clear();
            ProcPannel.Controls.AddRange(TpSoulsLogic.GetProcess_Buttons());
        }     

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (TpSoulsLogic.selectedProcButton != null)
            {
                string selectedName = TpSoulsLogic.selectedProcButton.assignedProcName;
                int selectedId = (int)TpSoulsLogic.selectedProcButton.assignedProcID;        

                TpSoulsLogic.ErrorType error = TpSoulsLogic.SetOffsets(selectedName);

                switch (error)
                {
                    case TpSoulsLogic.ErrorType.None:

                        bool openProc = TpSoulsLogic.memory.OpenProcess(selectedId);

                        if (!openProc)
                        {
                            MessageBox.Show("Failed to open selected process.", "ErrorMessage", MessageBoxButtons.OK);
                            TpSoulsLogic.ResetOffsets();
                            return;
                        }

                        TpSoulsLogic.selectedProcID = TpSoulsLogic.selectedProcButton.assignedProcID;
                        TpSoulsLogic.selectedProcName = TpSoulsLogic.selectedProcButton.assignedProcName;

                        SetAllProcessName(TpSoulsLogic.selectedProcButton.assignedProcName);

                        mainForm.varList.VarPanel.Controls.Clear();
                        mainForm.varList.VarPanel.Controls.AddRange(TpSoulsLogic.GetVarControls());

                        TpSoulsLogic.selectedProcButton = null;

                        mainForm.Enabled = true;
                        this.Hide();

                        break;

                    case TpSoulsLogic.ErrorType.FileDoesntExists:
                        MessageBox.Show("Cant find Offsets.txt file in base directory.", "ErrorMessage", MessageBoxButtons.OK);
                        break;

                    case TpSoulsLogic.ErrorType.WrongOffsetFormat:
                        MessageBox.Show("Wrong offset format in Offsets.txt file.", "ErrorMessage", MessageBoxButtons.OK);
                        break;

                    case TpSoulsLogic.ErrorType.NoOffsetsForProcess:
                        MessageBox.Show("Cant find offsets for selected process in Offsets.txt file.", "ErrorMessage", MessageBoxButtons.OK);
                        break;

                    default:
                        break;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            TpSoulsLogic.selectedProcButton = null;

            mainForm.Enabled = true;
            this.Hide();
        }
    }
}
