using System;
using System.Windows.Forms;
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
            mainForm.varList.SetProcessName(name);
        }

        public void CallProcessesPannel()
        {
            this.Show();

            MainLogic.currentProcs = ProcFinderWinAPI.GetProcesses();

            ProcPannel.Controls.Clear();
            ProcPannel.Controls.AddRange(MainLogic.GetProcess_Buttons());
        }     

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (MainLogic.selectedProcButton != null)
            {
                string selectedName = MainLogic.selectedProcButton.assignedProcName;
                int selectedId = (int)MainLogic.selectedProcButton.assignedProcID;        

                MainLogic.ErrorType error = MainLogic.SetPointers(selectedName);

                switch (error)
                {
                    case MainLogic.ErrorType.None:

                        bool openProc = MainLogic.memory.OpenProcess(selectedId);

                        if (!openProc)
                        {
                            MessageBox.Show("Failed to open selected process.", "ErrorMessage", MessageBoxButtons.OK);
                            MainLogic.ResetPointers();
                            return;
                        }

                        MainLogic.selectedProcID = MainLogic.selectedProcButton.assignedProcID;
                        MainLogic.selectedProcName = MainLogic.selectedProcButton.assignedProcName;

                        SetAllProcessName(MainLogic.selectedProcButton.assignedProcName);

                        mainForm.varList.VarPanel.Controls.Clear();
                        mainForm.varList.VarPanel.Controls.AddRange(MainLogic.GetVarControls());

                        MainLogic.selectedProcButton = null;

                        mainForm.Enabled = true;
                        this.Hide();

                        break;

                    case MainLogic.ErrorType.FileDoesntExists:
                        MessageBox.Show("Cant find Offsets.txt file in base directory.", "ErrorMessage", MessageBoxButtons.OK);
                        break;

                    case MainLogic.ErrorType.WrongPointerFormat:
                        MessageBox.Show("Wrong offset format in Offsets.txt file.", "ErrorMessage", MessageBoxButtons.OK);
                        break;

                    case MainLogic.ErrorType.NoPointersForProcess:
                        MessageBox.Show("Cant find offsets for selected process in Offsets.txt file.", "ErrorMessage", MessageBoxButtons.OK);
                        break;

                    default:
                        break;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainLogic.selectedProcButton = null;

            mainForm.Enabled = true;
            this.Hide();
        }
    }
}
