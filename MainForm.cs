using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TpSouls
{
    public partial class MainForm : Form
    {
        private TPointEdit editor;
        private ProcessesPannel procPannel;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetProcName(string name)
        {
            ProcName.Text = "";
            ProcName.Text += "ProcessName: " + name;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TpSoulsLogic.currentPath == null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "tp files (*.tp)|*.tp";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName;
                        TpSoulsLogic.currentPath = path;

                        TPoint.Save(path, TpSoulsLogic.selectedTPoints);

                        FileName.Text = "FileName: " + Path.GetFileName(path);
                    }
                }
            }
            else
            {
                TPoint.Save(TpSoulsLogic.currentPath, TpSoulsLogic.selectedTPoints);
            }
        }        

        private void LoadButton_Click(object sender, EventArgs e)
        {    
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "tp files (*.tp)|*.tp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    TpSoulsLogic.currentPath = path;

                    TpSoulsLogic.selectedTPoints = TPoint.Load(path);

                    TPointsPannel.Controls.Clear();
                    TPointsPannel.Controls.AddRange(TpSoulsLogic.GetTP_Buttons());

                    FileName.Text = "FileName: " + Path.GetFileName(path);
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TpSoulsLogic.currentPath = null;
            TpSoulsLogic.selectedTPbutton = null;

            TpSoulsLogic.selectedTPoints.Clear();

            TPointsPannel.Controls.Clear();

            FileName.Text = "FileName: None";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            editor.CallEditor(TPointEdit.EditorMode.AddNew);
            this.Enabled = false;            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            editor = new TPointEdit(this);
            procPannel = new ProcessesPannel(this);
            editor.Hide();
            procPannel.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (TpSoulsLogic.selectedTPbutton != null)
            {
                editor.CallEditor(TPointEdit.EditorMode.Edit);
                this.Enabled = false;
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (TpSoulsLogic.selectedTPbutton != null)
            {
                TpSoulsLogic.selectedTPoints.Remove(TpSoulsLogic.selectedTPbutton.assignedTPoint);
                this.TPointsPannel.Controls.Remove(TpSoulsLogic.selectedTPbutton);
                TpSoulsLogic.selectedTPbutton = null;
            }
        }

        private void TeleportButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectProcButton_Click(object sender, EventArgs e)
        {
            procPannel.CallProcessesPannel();
            this.Enabled = false;
        }
    }
}
