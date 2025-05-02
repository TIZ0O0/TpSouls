using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using TpSouls.UI_Elements;

namespace TpSouls
{
    internal static class TpSoulsLogic
    {
        public static string currentPath = null;

        public static Mem memory = new Mem();

        public static TPointButton selectedTPbutton = null;
        public static List<TPoint> selectedTPoints = new List<TPoint>();

        public static List<ProcFinderWinAPI.PROCESSENTRY32> currentProcs;

        public static ProcessButton selectedProcButton = null;
        public static string selectedProcName = null;
        public static uint selectedProcID = 0;

        private static List<string> varsOffsets = new List<string>();
            
        private static string offsetsX = null;
        private static string offsetsY = null;
        private static string offsetsZ = null;

        public enum ErrorType 
        { 
            None,
            FileDoesntExists,
            WrongOffsetFormat,
            NoOffsetsForProcess
        }

        public static void ResetSelectedProc()
        {
            selectedProcName = null;
            selectedProcID = 0;
        }

        public static void ResetOffsets()
        {
            offsetsX = null;
            offsetsY = null;
            offsetsZ = null;
            varsOffsets.Clear();
    }

        public static TPointButton[] GetTP_Buttons()
        {
            TPointButton[] tpButtons = new TPointButton[selectedTPoints.Count];

            for (int i = selectedTPoints.Count - 1, j = 0; i >= 0; i--, j++)
            {
                tpButtons[j] = new TPointButton(selectedTPoints[i]);
            }

            return tpButtons;
        }

        public static ProcessButton[] GetProcess_Buttons()
        {
            ProcessButton[] procButtons = new ProcessButton[currentProcs.Count];

            for (int i = currentProcs.Count - 1, j = 0; i >= 0; i--, j++)
            {
                procButtons[j] = new ProcessButton(currentProcs[i].th32ProcessID, currentProcs[i].szName);
            }

            return procButtons;
        }

        public static VarControl[] GetVarControls()
        {
            VarControl[] varCtrl = new VarControl[varsOffsets.Count];

            for (int i = varsOffsets.Count - 1, j = 0; i >= 0; i--, j++)
            {
                varCtrl[j] = new VarControl(GetName(varsOffsets[i]), GetOffsets(varsOffsets[i]));
            }

            return varCtrl;
        }

        public static void Teleport()
        {
            if (offsetsX != null && offsetsY != null && offsetsZ != null && selectedTPbutton != null)
            {
                memory.WriteMemory(offsetsX, "float", selectedTPbutton.assignedTPoint.posX.ToString());
                memory.WriteMemory(offsetsY, "float", selectedTPbutton.assignedTPoint.posY.ToString());
                memory.WriteMemory(offsetsZ, "float", selectedTPbutton.assignedTPoint.posZ.ToString());
            }
        }

        public static ErrorType SetOffsets(string selectedProcName)
        {
            string path = GetOffsetsFilePath();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    bool existFlag = false;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith(selectedProcName))
                        {
                            ResetOffsets();
                            GetNamesWithOffsets(line);
                            if (offsetsX == null || offsetsY == null || offsetsZ == null) 
                                return ErrorType.WrongOffsetFormat;
                            existFlag = true;
                            break;
                        }
                    }

                    if (!existFlag) return ErrorType.NoOffsetsForProcess;

                    return ErrorType.None;
                }
            }
            else return ErrorType.FileDoesntExists;
            
        }   

        private static string GetOffsetsFilePath()
        {
            string fileName = "Offsets.txt";
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }

        private static void GetNamesWithOffsets(string line)
        {          
            int startIndex = line.IndexOf(";") + 1;
            int endIndex = line.IndexOf(";", startIndex);

            string namesOffsets;

            while (endIndex != -1)
            {               
                namesOffsets = line.Substring(startIndex, endIndex - startIndex);
              
                if (GetName(namesOffsets) == "X") offsetsX = GetOffsets(namesOffsets);
                else if (GetName(namesOffsets) == "Y") offsetsY = GetOffsets(namesOffsets);
                else if (GetName(namesOffsets) == "Z") offsetsZ = GetOffsets(namesOffsets);
                
                else
                {
                    varsOffsets.Add(namesOffsets);                    
                }

                startIndex = endIndex + 1;
                endIndex = line.IndexOf(";", startIndex);
            }
        }

        private static string GetName(string line)
        {
            int endIndex = line.IndexOf(":");
            return line.Substring(0, endIndex);
        }

        private static string GetOffsets(string line)
        {
            int startIndex = line.IndexOf(":") + 1;
            return line.Substring(startIndex);
        }
    }
}
