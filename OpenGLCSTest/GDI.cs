using System;
using System.Runtime.InteropServices;

namespace OpenGLCSTest
{
    public static class GDI
    {
        [DllImport("gdi32.dll")]
        public static extern int ChoosePixelFormat(IntPtr hdc, [In] ref PixelFormatDescriptor pfd);

        [DllImport("gdi32.dll")]
        public static extern bool SetPixelFormat(IntPtr hdc, int format, ref PixelFormatDescriptor pfd);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern bool SwapBuffers(IntPtr hdc);
    }
}
