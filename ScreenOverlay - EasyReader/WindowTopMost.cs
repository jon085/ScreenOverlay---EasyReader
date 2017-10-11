using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenOverlay___EasyReader
{
    class WindowTopMost
    {
        private static readonly System.IntPtr HWND_TOPMOST = new System.IntPtr(-1);
        private static readonly System.IntPtr HWND_NOT_TOPMOST = new System.IntPtr(-2);
 
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        public static void InitTimer(IntPtr hWnd)
        {
            //This function just brings the window to the topmost every 100ms due to window going behind the start menu when it's displayed
            MainHWND = hWnd;
            TimerCallback tmCallback = SetWindowTopMostCycle;
            Timer timer = new Timer(tmCallback, "test", 0, 100);
            Console.WriteLine("Press any key to exit the sample");
            Console.ReadLine(); 
        }

        private static IntPtr MainHWND;

        static void SetWindowTopMostCycle(object objectInfo)
        {
            MakeWindowTopMost(MainHWND);
        }

        public static void MakeWindowTopMost(IntPtr hWnd)
        {
            SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

    }
}
