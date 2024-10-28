using System;
using System.Runtime.InteropServices;

namespace MonoGame.Utilities
{
    /* Extensions to simplify IntPtr operators missing in NET 2.0 */
    internal static class IntPtrExtensions
    {
        public static IntPtr Add(this IntPtr ptr, int offset)
        {
            return new IntPtr(ptr.ToInt32() + offset);
        }
    }
}