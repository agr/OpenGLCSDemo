using System;
using System.Runtime.InteropServices;

namespace OpenGLCSTest
{
    public static class GL
    {
        [DllImport("opengl32.dll")]
        public static extern IntPtr wglCreateContext(IntPtr hdc);

        // wglDeleteContext should be here somewhere, too

        [DllImport("opengl32.dll")]
        public static extern bool wglMakeCurrent(IntPtr hdc, IntPtr hglrc);

        [DllImport("opengl32.dll")]
        public static extern void glClear(uint clearMask);

        [DllImport("opengl32.dll")]
        public static extern void glClearColor(float r, float g, float b, float a);

        [DllImport("opengl32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr wglGetProcAddress(/*[MarshalAs(UnmanagedType.LPStr)]*/string functionName);
    }
}
