using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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

        private static List<string> varsPointers = new List<string>();
            
        private static string pointerX = null;
        private static string pointerY = null;
        private static string pointerZ = null;

        public enum ErrorType 
        { 
            None,
            FileDoesntExists,
            WrongPointerFormat,
            NoPointersForProcess,
            UnknownType,
            FailedToWriteMemory
        }

        public static void ResetSelectedProc()
        {
            selectedProcName = null;
            selectedProcID = 0;
        }

        public static void ResetPointers()
        {
            pointerX = null;
            pointerY = null;
            pointerZ = null;
            varsPointers.Clear();
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
            VarControl[] varCtrl = new VarControl[varsPointers.Count];

            for (int i = varsPointers.Count - 1, j = 0; i >= 0; i--, j++)
            {
                varCtrl[j] = new VarControl(mainForm.varList, GetName(varsPointers[i]), 
                    GetPointer(varsPointers[i]), GetValueType(varsPointers[i]));
            }            

            return varCtrl;
        }

        public static void Teleport()
        {
            if (pointerX != null && pointerY != null && pointerZ != null && selectedTPbutton != null)
            {
                memory.WriteMemory(pointerX, "float", selectedTPbutton.assignedTPoint.posX.ToString());
                memory.WriteMemory(pointerY, "float", selectedTPbutton.assignedTPoint.posY.ToString());
                memory.WriteMemory(pointerZ, "float", selectedTPbutton.assignedTPoint.posZ.ToString());
            }
        }

        public static ErrorType SetValue(string pointer, string type, string value)
        {
            if (!supportedValueTypes.Contains(type)) return ErrorType.UnknownType;

            bool success = memory.WriteMemory(pointer, type, value);

            if (success) return ErrorType.None;
            else return ErrorType.FailedToWriteMemory;       
        }

        public static bool SetValueFreezeState(string pointer, string type, string value, bool freezeState)
        {
            if (!supportedValueTypes.Contains(type)) return false;

            bool succes;

            if (freezeState == true) succes = memory.FreezeValue(pointer, type, value);
            else
            {
                memory.UnfreezeValue(pointer);
                succes = true;
            }

            return succes;
        }

        public static string GetValue(string pointer, string type)
        {
            switch (type)
            {
                case "byte":
                    return memory.ReadByte(pointer).ToString();

                case "int":
                    return memory.ReadInt(pointer).ToString();

                case "float":
                    return memory.ReadFloat(pointer).ToString();

                case "double":
                    return memory.ReadDouble(pointer).ToString();

                case "long":
                    return memory.ReadLong(pointer).ToString();

                case "string":
                    return memory.ReadString(pointer);

                default:
                    return "UnknownValueType";
            }
        }

        public static ErrorType SetPointers(string selectedProcName)
        {
            string path = GetPointersFilePath();

            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                text = Regex.Replace(text, @"\s+", "");

                ErrorType error = ErrorType.None;
                string procInfo = GetInfoForProcess(text, selectedProcName, ref error);

                if (error != ErrorType.None) return error;

                ResetPointers();
                GetNamesWithPointers(procInfo);

                if (pointerX == null || pointerY == null || pointerZ == null)
                    error = ErrorType.WrongPointerFormat;

                return error;
            }
            else return ErrorType.FileDoesntExists;
            
        }   

        private static string GetInfoForProcess(string text, string selectedProcName, ref ErrorType error)
        {
            int startIndex = text.IndexOf(selectedProcName) + selectedProcName.Length;
            if (startIndex == -1)
            {
                error = ErrorType.NoPointersForProcess;
                return "";
            }

            startIndex = text.IndexOf("{", startIndex) + 1;
            int endIndex = text.IndexOf("}", startIndex);
            if (startIndex == -1 || endIndex == -1)
            {
                error = ErrorType.WrongPointerFormat;
                return "";
            }

            return text.Substring(startIndex, endIndex - startIndex);
        }

        private static string GetPointersFilePath()
        {
            string fileName = "Pointers.txt";
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }

        private static void GetNamesWithPointers(string line)
        {          
            int startIndex = 0;
            int endIndex = line.IndexOf(";", startIndex);

            string namesOffsets;

            while (endIndex != -1)
            {               
                namesOffsets = line.Substring(startIndex, endIndex - startIndex);
              
                if (GetName(namesOffsets) == "X") pointerX = GetPointer(namesOffsets);
                else if (GetName(namesOffsets) == "Y") pointerY = GetPointer(namesOffsets);
                else if (GetName(namesOffsets) == "Z") pointerZ = GetPointer(namesOffsets);
                
                else
                {
                    varsPointers.Add(namesOffsets);                    
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

        private static string GetPointer(string line)
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
