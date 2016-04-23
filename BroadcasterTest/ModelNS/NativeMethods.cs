using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace BroadcasterTest.ModelNS
{
    public static class NativeMethods
    {
        public static Rectangle TryGetWindowRectagle( IntPtr hWnd )
        {
            Rectangle rect = new Rectangle();
            GetWindowRect( hWnd, ref rect );
            return rect;
        }

        /// <summary>Returns a dictionary that contains the handle and title of all the open windows.</summary>
        /// <returns>A dictionary that contains the handle and title of all the open windows.</returns>
        /// http://www.tcx.be/blog/2006/list-open-windows/
        public static Dictionary<IntPtr, string> GetOpenWindows
        {
            get
            {
                IntPtr shellWindow = GetShellWindow();
                Dictionary<IntPtr, string> windows = new Dictionary<IntPtr, string>();

                EnumWindows( delegate ( IntPtr hWnd, int lParam )
                {
                    if (hWnd == shellWindow) return true;
                    if (!IsWindowVisible( hWnd )) return true;

                    int length = GetWindowTextLength( hWnd );
                    if (length == 0) return true;

                    StringBuilder builder = new StringBuilder( length );
                    int hRes = GetWindowText( hWnd, builder, length + 1 );

                    if (hRes != 0)
                    {
                        windows[ hWnd ] = builder.ToString();
                    }
                    
                    return true;

                }, 0 );

                return windows;
            }
        }

        private delegate bool EnumWindowsProc( IntPtr hWnd, int lParam );

        [DllImport( "USER32.DLL" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        private static extern bool EnumWindows( EnumWindowsProc enumFunc, int lParam );

        //https://msdn.microsoft.com/ru-ru/library/windows/desktop/ms633520(v=vs.85).aspx
        [DllImport( "USER32.DLL", CharSet = CharSet.Unicode )]
        private static extern int GetWindowText( IntPtr hWnd, StringBuilder lpString, int nMaxCount );

        [DllImport( "USER32.DLL" )]
        private static extern int GetWindowTextLength( IntPtr hWnd );

        [DllImport( "USER32.DLL" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        private static extern bool IsWindowVisible( IntPtr hWnd );

        [DllImport( "USER32.DLL" )]
        private static extern IntPtr GetShellWindow();

        [DllImport( "user32.dll" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        private static extern bool GetWindowRect( IntPtr hWnd, ref Rectangle lpRect );
    }

    //[StructLayout(LayoutKind.Sequential)]
    //public struct RECT
    //{
    //    public int Left;        // x position of upper-left corner  
    //    public int Top;         // y position of upper-left corner  
    //    public int Right;       // x position of lower-right corner  
    //    public int Bottom;      // y position of lower-right corner  
    //}
}
