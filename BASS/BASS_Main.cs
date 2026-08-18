using System;
using System.Runtime.InteropServices;

public static class BASS_Main
{
    private const string BASS_DLL = "bass";

    public const uint BASS_FILE_NAME = 0;
    public const uint BASS_FILE_MEM = 1;

    public const uint BASS_SAMPLE_LOOP = 4;
    public const uint BASS_ATTRIB_VOL = 2;
    public const uint BASS_UNICODE = 0x80000000;

    [DllImport(BASS_DLL, EntryPoint = "BASS_Init")]
    public static extern bool BASS_Init(int device, uint freq, uint flags, IntPtr win, IntPtr clsid);

    [DllImport(BASS_DLL, EntryPoint = "BASS_StreamCreateFile")]
    public static extern int BASS_StreamCreateFileFromMemory(
        uint filetype,
        IntPtr memoryAddress,
        ulong offset,
        ulong length,
        uint flags
    );

    [DllImport(BASS_DLL, EntryPoint = "BASS_StreamCreateFile", CharSet = CharSet.Unicode)]
    public static extern int BASS_StreamCreateFile(
        uint filetype,
        [MarshalAs(UnmanagedType.LPWStr)] string file,
        ulong offset,
        ulong length,
        uint flags
    );

    [DllImport(BASS_DLL, EntryPoint = "BASS_ChannelPlay")]
    public static extern bool BASS_ChannelPlay(int handle, bool restart);

    [DllImport(BASS_DLL, EntryPoint = "BASS_ChannelPause")]
    public static extern bool BASS_ChannelPause(int handle);

    [DllImport(BASS_DLL, EntryPoint = "BASS_ChannelStop")]
    public static extern bool BASS_ChannelStop(int handle);

    [DllImport(BASS_DLL, EntryPoint = "BASS_ChannelSetAttribute")]
    public static extern bool BASS_ChannelSetAttribute(int handle, uint attrib, float value);

    [DllImport(BASS_DLL, EntryPoint = "BASS_Free")]
    public static extern bool BASS_Free();
}
