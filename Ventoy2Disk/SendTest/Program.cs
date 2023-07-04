using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace SendTest;
/*
[StructLayout(LayoutKind.Sequential)]
struct TEST
{
    int tint;
    byte tuchar;
    short tshort;
    char tchar;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    char[] tcharlb64;
    [MarshalAs(UnmanagedType.)]
    string tcharlp;
}*/

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
public struct TEST
{

    /// int
    public int tint;

    /// byte
    public byte tuchar;

    /// short
    public short tshort;

    /// char
    public byte tchar;

    /// char[64]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 64)]
    public string tcharlb64;
}


/*
[StructLayout(LayoutKind.Sequential)]
struct PART_TABLE
{
    byte Active; // 0x00  0x80

    byte StartHead;
    ushort StartSector : 6;
    ushort StartCylinder : 10;

    byte FsFlag;

    byte EndHead;
    ushort EndSector;
    ushort EndCylinder;

    uint StartSectorId;
    uint SectorCount;
}
[StructLayout(LayoutKind.Sequential)]
struct MBR_HEAD
{
    [MarshalAs(UnmanagedType., SizeConst = 446)]
    byte[] BootCode;
    PART_TABLE[] PartTbl;
    byte Byte55;
    byte ByteAA;
}

enum _STORAGE_BUS_TYPE
{
    BusTypeUnknown = 0x00,
    BusTypeScsi,
    BusTypeAtapi,
    BusTypeAta,
    BusType1394,
    BusTypeSsa,
    BusTypeFibre,
    BusTypeUsb,
    BusTypeRAID,
    BusTypeiScsi,
    BusTypeSas,
    BusTypeSata,
    BusTypeSd,
    BusTypeMmc,
    BusTypeVirtual,
    BusTypeFileBackedVirtual,
    BusTypeSpaces,
    BusTypeNvme,
    BusTypeSCM,
    BusTypeUfs,
    BusTypeMax,
    BusTypeMaxReserved = 0x7F
}


[StructLayout(LayoutKind.Sequential)]
struct PHY_DRIVE_INFO
{
    int Id;
    int PhyDrive;
    int PartStyle;//0:MBR 1:GPT
    ulong SizeInBytes;
    byte DeviceType;
    int RemovableMedia;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    char[] VendorId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    char[] ProductId;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    char[] ProductRev;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    char[] SerialNumber;
    STORAGE_BUS_TYPE BusType;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    char[] DriveLetters;

    int VentoyFsClusterSize;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    char[] VentoyFsType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    char[] VentoyVersion;

    int SecureBootSupport;
    MBR_HEAD MBR;
    ulong Part2GPTAttr;

    int ResizeNoShrink;
    ulong ResizeOldPart1Size;
    char Part1DriveLetter;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    char[] ResizeVolumeGuid;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    char[] FsName;
    ulong ResizePart2StartSector;
    VTOY_GPT_INFO Gpt;

}*/

internal class Program
{
    public static IntPtr zero = IntPtr.Zero;
    [DllImport("User32.dll")]
    static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wapram, IntPtr lparam);
    [DllImport("User32.dll")]
    static extern IntPtr FindWindow(string lpwindowclass, string lpwindowtile);
    [DllImport("User32.dll")]
    static extern int ShowWindow(IntPtr hwnd, int show);
    [DllImport("kernel32.dll")]
    static extern int GetLastError();
    [DllImport("D:\\Program Files\\ventoy-1.0.86-windows\\ventoy-1.0.86\\Ventoy2Disk_X64.dll")]
    static extern int TS();
    [DllImport("D:\\Program Files\\ventoy-1.0.86-windows\\ventoy-1.0.86\\Ventoy2Disk_X64.dll")]
    static extern TEST returnteststruct();
    static void Main(string[] args)
    {
        IntPtr hwnd = FindWindow("VENTOY","114514");
        Thread.Sleep(600);
        /*
        ShowWindow(hwnd, 0);
        if (hwnd == IntPtr.Zero)
            Console.WriteLine("Error!");*/
        SendMessage(hwnd, 0x701, zero, zero);
        Console.WriteLine(GetLastError());
        Console.WriteLine(TS());
        Console.WriteLine(TS());
        TEST t = returnteststruct();

        Console.ReadLine();
    }
}
