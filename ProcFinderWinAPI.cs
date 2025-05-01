using System.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using static TpSouls.ProcFinderWinAPI;

namespace TpSouls
{
    internal class ProcFinderWinAPI
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESSENTRY32
        {
            public uint dwSize;
            public uint cntUsage;
            public uint th32ProcessID;
            public IntPtr th32DefaultHeapID;
            public uint th32ModuleID;
            public uint cntThreads;
            public uint th32ParentProcessID;
            public int pcPriClassBase;
            public uint dwFlags;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szName;
        }

        private const uint TH32CS_SNAPPROCESS = 0x00000002;

        private const uint PROCESS_QUERY_INFORMATION = 0x0400;
        private const uint PROCESS_VM_READ = 0x0010;

        private static string[] blackList = new string[] { 
            "System.exe", "Idle.exe", "smss.exe", "csrss.exe", "wininit.exe", "svchost.exe", "services.exe",
            "lsass.exe", "winlogon.exe", "dwm.exe", "conhost.exe", "msedgewebview2.exe", "dllhost.exe"

        };

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateToolhelp32Snapshot(uint dwFlags, uint th32ProcessID);

        [DllImport("kernel32.dll")]
        private static extern bool Process32First(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32.dll")]
        private static extern bool Process32Next(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(uint dwDesiredAcces, bool binheritHandle, uint dwProcessID);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool QueryFullProcessImageName(IntPtr hProcess, int flags, System.Text.StringBuilder text, ref int size);

        public static List<PROCESSENTRY32> GetProcesses()
        {
            List<PROCESSENTRY32> procs = new List<PROCESSENTRY32>();

            IntPtr hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);

            PROCESSENTRY32 procEntry = new PROCESSENTRY32();
            procEntry.dwSize = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));

            if (Process32First(hSnapshot, ref procEntry))
            {
                do
                {
                    if (!ProcFilter(procEntry)) continue;
                    procs.Add(procEntry);
                } while (Process32Next(hSnapshot, ref procEntry));
            }

            CloseHandle(hSnapshot);

            return procs;
        }

        private static string GetProcessPath(PROCESSENTRY32 proc)
        {
            var buffer = new System.Text.StringBuilder(1024);
            int size = buffer.Capacity;
            IntPtr handle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, false, proc.th32ParentProcessID);

            if (QueryFullProcessImageName(handle, 0, buffer, ref size))           
                return buffer.ToString();

            return null;
        }

        private static bool CheckForPath(PROCESSENTRY32 proc)
        {
            string path = GetProcessPath(proc);

            if (string.IsNullOrEmpty(path) || path.ToLower().StartsWith(@"c:\windows\system32"))
                return false;

            else return true;
        }

        private static bool CheckForName(PROCESSENTRY32 proc)
        {
            if (string.IsNullOrEmpty(proc.szName) ||
                blackList.Contains(proc.szName.ToLower()) ||
                proc.th32ProcessID <= 4)
            {
                return false;
            }
            else return true;
        }

        private static bool ProcFilter(PROCESSENTRY32 proc)
        {
            if (CheckForName(proc) && CheckForPath(proc)) return true;
            else return false;
        }
    }
}
