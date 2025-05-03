using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using TpSouls.Forms;
using TpSouls.UI_Elements;

namespace TpSouls
{
    internal static class TpSoulsLogic
    {
        public static MainForm mainForm;

        public static string currentPath = null;

        public static Mem memory = new Mem();

        public static TPointButton selectedTPbutton = null;
        public static List<TPoint> selectedTPoints = new List<TPoint>();

        public static VarControl selectedVarCtrl = null;

        public static List<ProcFinderWinAPI.PROCESSENTRY32> currentProcs;

        public static ProcessButton selectedProcButton = null;
        public static string selectedProcName = null;
        public static uint selectedProcID = 0;

        private static readonly string[] supportedValueTypes = { "byte", "int", "float", "double", "long", "string" };

        private static List<string> varsOffsets = new List<string>();
            
        private static string offsetsX = null;
        private static string offsetsY = null;
        private static string offsetsZ = null;

        public enum ErrorType 
        { 
            None,
            FileDoesntExists,
            WrongOffsetFormat,
            NoOffsetsForProcess,
            UnknownType,
            FailedToWriteMemory
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
                varCtrl[j] = new VarControl(mainForm.varList, GetName(varsOffsets[i]), 
                    GetOffsets(varsOffsets[i]), GetValueType(varsOffsets[i]));
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

        public static ErrorType SetValue(string offsets, string type, string value)
        {
            if (!supportedValueTypes.Contains(type)) return ErrorType.UnknownType;

            bool success = memory.WriteMemory(offsets, type, value);

            if (success) return ErrorType.None;
            else return ErrorType.FailedToWriteMemory;       
        }

        public static string GetValue(string offsets, string type)
        {
            switch (type)
            {
                case "byte":
                    return memory.ReadByte(offsets).ToString();

                case "int":
                    return memory.ReadInt(offsets).ToString();

                case "float":
                    return memory.ReadFloat(offsets).ToString();

                case "double":
                    return memory.ReadDouble(offsets).ToString();

                case "long":
                    return memory.ReadLong(offsets).ToString();

                case "string":
                    return memory.ReadString(offsets);

                default:
                    return "UnknownValueType";
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

            try
            {
                return line.Substring(0, endIndex);
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }

        private static string GetOffsets(string line)
        {
            int startIndex = line.IndexOf(":") + 1;
            int endIndex = line.IndexOf(":", startIndex);

            try
            {
                return line.Substring(startIndex, endIndex - startIndex);
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }

        private static string GetValueType(string line)
        {
            int startIndex = line.IndexOf(":") + 1;
            startIndex = line.IndexOf(":", startIndex) + 1;

            try
            {
                return line.Substring(startIndex);
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }
    }
}
