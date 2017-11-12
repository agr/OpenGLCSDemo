using System;
using System.Runtime.InteropServices;

namespace OpenGLCSTest
{
    public static class WinUser
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hdc);
    }
}
