using System.Runtime.InteropServices;

namespace OpenGLCSTest
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormatDescriptor
    {
        public static PixelFormatDescriptor Create()
        {
            var pfd = new PixelFormatDescriptor();

            pfd.nSize = (ushort)Marshal.SizeOf(typeof(PixelFormatDescriptor));
            pfd.nVersion = 1;
            pfd.dwFlags = 0x04 | 0x20 | 0x01; // PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER
            pfd.iPixelType = 0; // PFD_TYPE_RGBA
            pfd.cColorBits = 32;
            pfd.cRedBits = pfd.cRedShift = pfd.cGreenBits = pfd.cGreenShift = pfd.cBlueBits = pfd.cBlueShift = 0;
            pfd.cAlphaBits = pfd.cAlphaShift = 0;
            pfd.cAccumBits = pfd.cAccumRedBits = pfd.cAccumGreenBits = pfd.cAccumBlueBits = pfd.cAccumAlphaBits = 0;
            pfd.cDepthBits = 24;
            pfd.cStencilBits = 8;
            pfd.cAuxBuffers = 0;
            pfd.iLayerType = 0; // PFD_MAIN_PLANE
            pfd.bReserved = 0;
            pfd.dwLayerMask = pfd.dwVisibleMask = pfd.dwDamageMask = 0;

            return pfd;
        }

        ushort nSize;
        ushort nVersion;
        uint dwFlags;
        byte iPixelType;
        byte cColorBits;
        byte cRedBits;
        byte cRedShift;
        byte cGreenBits;
        byte cGreenShift;
        byte cBlueBits;
        byte cBlueShift;
        byte cAlphaBits;
        byte cAlphaShift;
        byte cAccumBits;
        byte cAccumRedBits;
        byte cAccumGreenBits;
        byte cAccumBlueBits;
        byte cAccumAlphaBits;
        byte cDepthBits;
        byte cStencilBits;
        byte cAuxBuffers;
        byte iLayerType;
        byte bReserved;
        uint dwLayerMask;
        uint dwVisibleMask;
        uint dwDamageMask;
    }
}
