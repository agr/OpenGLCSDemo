using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OpenGLCSTest
{
    public partial class Form1 : Form
    {
        private delegate void GlCompileShaderDelegate(uint shader);

        IntPtr hglrc;
        IntPtr hdc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // code
            var pfd = PixelFormatDescriptor.Create();
            hdc = WinUser.GetDC(this.Handle);
            int format = GDI.ChoosePixelFormat(hdc, ref pfd);
            GDI.SetPixelFormat(hdc, format, ref pfd);

            hglrc = GL.wglCreateContext(hdc);

            if (hglrc == null)
            {
                throw new Exception("Failed to initialize OpenGL");
            }

            GL.wglMakeCurrent(hdc, hglrc);

            GL.glClearColor(0.5f, 0.0f, 0.0f, 1.0f);

            LoadGlCompileShader();
        }

        private static void LoadGlCompileShader()
        {
            // wglGetProcAddress MUST be called AFTER wglMakeCurrent is called AND on the same thread
            IntPtr glCompileShaderPtr = GL.wglGetProcAddress("glCompileShader");

            if (glCompileShaderPtr == IntPtr.Zero)
            {
                var error = Marshal.GetLastWin32Error();
                throw new Exception("Failed to load glCompileShader address");
            }

            GlCompileShaderDelegate glCompileShader = Marshal.GetDelegateForFunctionPointer<GlCompileShaderDelegate>(glCompileShaderPtr);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GL.glClear(0x4000); //GL_COLOR_BUFFER_BIT
            GDI.SwapBuffers(hdc);
        }
    }
}
