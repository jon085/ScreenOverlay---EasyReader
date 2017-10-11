using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Created by Jonathan Kartun
	   2017/10/10
*/

namespace ScreenOverlay___EasyReader
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern int User32_GetWindowLong(IntPtr hWnd, GetWindowLong nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int User32_SetWindowLong(IntPtr hWnd, GetWindowLong nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern bool User32_SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte bAlpha, LayeredWindowAttributes dwFlags);

        public Form1()
        {
            InitializeComponent();

            ShowSettingsWindow();

            //WindowTopMost.MakeWindowTopMost(this.Handle);

            WindowTopMost.InitTimer(this.Handle);
        }

        void ShowSettingsWindow()
        {
            FormSettings fs = new FormSettings();
            fs.frmReference = this;

            fs.hScrollAlpha.Value = 100;
            fs.hScroll_R.Value = 50;
            fs.hScroll_G.Value = 50;
            fs.hScroll_B.Value = 255;
            fs.Show();
        }

        private enum GetWindowLong
        {
            GWL_EXSTYLE = -20 // Sets a new extended window style.
        }

        private enum ExtendedWindowStyles
        {
            /// Layered window. http://msdn.microsoft.com/en-us/library/windows/desktop/ms632599%28v=vs.85%29.aspx#layered
            WS_EX_TRANSPARENT = 0x20,
            WS_EX_LAYERED = 0x80000
        }

        private enum LayeredWindowAttributes
        {
            LWA_COLORKEY = 0x1, // Use bAlpha to determine the opacity of the layered window.
            LWA_ALPHA = 0x2     // Use crKey as the transparency color.
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //this.TopMost = true; // make the form always on top
            //this.TopLevel = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            //Setup Click through
            int wl = User32_GetWindowLong(this.Handle, GetWindowLong.GWL_EXSTYLE);
            User32_SetWindowLong(this.Handle, GetWindowLong.GWL_EXSTYLE, wl | (int)ExtendedWindowStyles.WS_EX_LAYERED | (int)ExtendedWindowStyles.WS_EX_TRANSPARENT);

            updateBackgroundColour(100, 50, 50, 255);
        }

        public void updateBackgroundColour(int iAlpha, int iR, int iG, int iB)
        {
            this.BackColor = Color.FromArgb(iR, iG, iB);

            //Change Alpha
            User32_SetLayeredWindowAttributes(this.Handle, (TransparencyKey.B << 16) + (TransparencyKey.G << 8) + TransparencyKey.R, (byte)iAlpha, LayeredWindowAttributes.LWA_COLORKEY | LayeredWindowAttributes.LWA_ALPHA);
        }
    }
}