using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace DSDC
{
    class DSMiner
    {
        private IntPtr processHandle;
        private Process process;
        private string procName;

        const int PROCESS_WM_READ = 0x0010;

        //IntPtr baseOffset = new IntPtr(0x0B6F31F0);
        IntPtr baseOffset = new IntPtr(0x00FDAD30);

        const int DS_DEATHS_OFFS = 0x5C;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        public DSMiner(string exeName)
        {
            procName = exeName;

            try
            {
                process = Process.GetProcessesByName(procName)[0];
            }
            catch
            {
                throw new Exception("Cannot find Dark Souls.");
            }

            processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);

            if (processHandle == IntPtr.Zero)
            {
                throw new Exception("Cannot open Dark Souls.");
            }
        }


        public int readDeaths()
        {
            byte[] buffer = new byte[4];
            IntPtr ptrBytesRead;
            IntPtr dataAddress = new IntPtr(0);

            try
            {
                dataAddress = new IntPtr(process.MainModule.BaseAddress.ToInt32() + baseOffset.ToInt32());
            }
            catch
            {
                return -1;
            }


            ReadProcessMemory(processHandle, dataAddress, buffer, 4, out ptrBytesRead);

            int bytesRead = ptrBytesRead.ToInt32();

            if (bytesRead == 4)
            {
                int address = BitConverter.ToInt32(buffer, 0);
                address += DS_DEATHS_OFFS;

                ReadProcessMemory(processHandle, (IntPtr)address, buffer, 4, out ptrBytesRead);

                bytesRead = ptrBytesRead.ToInt32();

                if (bytesRead == 4)
                {
                    return BitConverter.ToInt32(buffer, 0);
                }
                else
                {
                    return -1;
                }
            }
            else
                return -1;
        }

        public bool isProcessRunning()
        {
            try
            {
                Process p = Process.GetProcessesByName(procName)[0];
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
