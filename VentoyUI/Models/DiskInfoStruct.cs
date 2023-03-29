/*using GUID = Ventoy2Disk._GUID

namespace Ventoy2Disk;

struct VTOY_GPT_PART_TBL
{
    GUID   PartType;
    GUID   PartGuid;
    ulong StartLBA;
    ulong LastLBA;
    ulong Attr;
    string Name;
}

struct VTOY_GPT_HDR
{
    char[]   Signature; /* EFI PART 
    byte[]  Version;
    uint Length;
    uint Crc;
    byte[]  Reserved1;
    ulong EfiStartLBA;
    ulong EfiBackupLBA;
    ulong PartAreaStartLBA;
    ulong PartAreaEndLBA;
    GUID   DiskGuid;
    ulong PartTblStartLBA;
    uint PartTblTotNum;
    uint PartTblEntryLen;
    uint PartTblCrc;
    byte[]  Reserved2;
}

struct PART_TABLE
{
    byte  Active; // 0x00  0x80

    byte  StartHead;
    ushort StartSector : 6;
    ushort StartCylinder : 10;

    byte  FsFlag;

    byte  EndHead;
    ushort EndSector : 6;
    ushort EndCylinder : 10;

    uint StartSectorId;
    uint SectorCount;
}

struct _GUID {
    ulong  Data1;
    ushort Data2;
    ushort Data3;
    byte  Data4;
}

struct VTOY_GPT_HDR
{
    char[]   Signature; /* EFI PART 
    byte[]  Version;
    uint Length;
    uint Crc;
    byte[]  Reserved1;
    ulong EfiStartLBA;
    ulong EfiBackupLBA;
    ulong PartAreaStartLBA;
    ulong PartAreaEndLBA;
    GUID   DiskGuid;
    ulong PartTblStartLBA;
    uint PartTblTotNum;
    uint PartTblEntryLen;
    uint PartTblCrc;
    byte[]  Reserved2;
}

struct MBR_HEAD
{
    byte[] BootCode;
    PART_TABLE[] PartTbl;
    byte Byte55;
    byte ByteAA;
}

enum _STORAGE_BUS_TYPE {
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

struct VTOY_GPT_INFO
{
    MBR_HEAD MBR;
    VTOY_GPT_HDR Head;
    VTOY_GPT_PART_TBL[] PartTbl;
}

struct PHY_DRIVE_INFO
{
    int Id;
    int PhyDrive;
    int PartStyle;//0:MBR 1:GPT
    ulong SizeInBytes;
    byte DeviceType;
    int RemovableMedia;
    char VendorId[128];
    char ProductId[128];
    char ProductRev[128];
    char SerialNumber[128];
    STORAGE_BUS_TYPE BusType;

    char DriveLetters[64];

    int  VentoyFsClusterSize;
    char VentoyFsType[16];
    char VentoyVersion[32];

    int SecureBootSupport;
    MBR_HEAD MBR;
    ulong Part2GPTAttr;

    int ResizeNoShrink;
    ulong ResizeOldPart1Size;
    char Part1DriveLetter;
    char ResizeVolumeGuid[64];
    char FsName[64];
    ulong ResizePart2StartSector;
    VTOY_GPT_INFO Gpt;

}*/