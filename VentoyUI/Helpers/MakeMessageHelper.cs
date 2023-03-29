using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VentoyUI.Helpers;
internal class MakeMessageHelper
{
    public static ulong MakeWParam(int l, int h)
    {
        return (ulong)(int)((long)(((ushort)(((ulong)(l)) & 0xffff)) | ((int)((ushort)(((ulong)(h)) & 0xffff))) << 16));
    }
    public static long MakeLParam(int l, int h)
    {
        return (long)(int)((long)(((ushort)(((ulong)(l)) & 0xffff)) | ((int)((ushort)(((ulong)(h)) & 0xffff))) << 16));
    }
    public static ushort Loword(long v)
    {
        return ((ushort)(((ulong)(v)) & 0xffff));
    }
    public static ushort Hiword(long v)
    {
        return ((ushort)((((ulong)(v)) >> 16) & 0xffff));
    }
}
