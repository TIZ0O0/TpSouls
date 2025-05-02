using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace TpSouls
{
    internal static class TpSoulsLogic
    {
        public static string currentPath = null;

        public static Mem memory = new Mem();

        public static TPointButton selectedTPbutton = null;
        public static List<TPoint> selectedTPoints = new List<TPoint>();

        public static ProcessButton selectedProcButton = null;
        public static List<ProcFinderWinAPI.PROCESSENTRY32> currentProcs;

        public static string selectedProcName = null;
        public static uint selectedProcID = 0;

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
                            offsetsX = GetOffsets(line, "X");
                            offsetsY = GetOffsets(line, "Y");
                            offsetsZ = GetOffsets(line, "Z");
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

        private static string GetOffsets(string line, string axis)
        {
            int startIndex = line.IndexOf(axis + ":");
            int endIndex = line.IndexOf(";", startIndex);
            if (startIndex != -1 && endIndex != -1)
            {
                string offsets = line.Substring(startIndex + 2, endIndex - (startIndex + 2));
                return offsets;
            }
            else
            {
                return null;
            }

            //bool exitFlag = true;

            //int startIndex;
            //int endIndex;

            //while (exitFlag)
            //{
            //    startIndex = line.IndexOf(";");
            //}

        }
    }
}
