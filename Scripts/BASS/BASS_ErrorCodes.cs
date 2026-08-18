public static class BASS_ErrorCodes
{
    // Error codes returned by BASS_ErrorGetCode
    public const int BASS_OK = 0; // all is OK
    public const int BASS_ERROR_MEM = 1; // memory error
    public const int BASS_ERROR_FILEOPEN = 2; // can't open the file
    public const int BASS_ERROR_DRIVER = 3; // can't find a free/valid driver
    public const int BASS_ERROR_BUFLOST = 4; // the sample buffer was lost
    public const int BASS_ERROR_HANDLE = 5; // invalid handle
    public const int BASS_ERROR_FORMAT = 6; // unsupported sample format
    public const int BASS_ERROR_POSITION = 7; // invalid position
    public const int BASS_ERROR_INIT = 8; // BASS_Init has not been successfully called
    public const int BASS_ERROR_START = 9; // BASS_Start has not been successfully called
    public const int BASS_ERROR_SSL = 10; // SSL/HTTPS support isn't available
    public const int BASS_ERROR_REINIT = 11; // device needs to be reinitialized
    public const int BASS_ERROR_TRACK = 13; // invalid track number
    public const int BASS_ERROR_ALREADY = 14; // already initialized/paused/whatever
    public const int BASS_ERROR_NOTAUDIO = 17; // file does not contain audio
    public const int BASS_ERROR_NOCHAN = 18; // can't get a free channel
    public const int BASS_ERROR_ILLTYPE = 19; // an illegal type was specified
    public const int BASS_ERROR_ILLPARAM = 20; // an illegal parameter was specified
    public const int BASS_ERROR_NO3D = 21; // no 3D support
    public const int BASS_ERROR_NOEAX = 22; // no EAX support
    public const int BASS_ERROR_DEVICE = 23; // illegal device number
    public const int BASS_ERROR_NOPLAY = 24; // not playing
    public const int BASS_ERROR_FREQ = 25; // illegal sample rate
    public const int BASS_ERROR_NOTFILE = 27; // the stream is not a file stream
    public const int BASS_ERROR_NOHW = 29; // no hardware voices available
    public const int BASS_ERROR_EMPTY = 31; // the file has no sample data
    public const int BASS_ERROR_NONET = 32; // no internet connection could be opened
    public const int BASS_ERROR_CREATE = 33; // couldn't create the file
    public const int BASS_ERROR_NOFX = 34; // effects are not available
    public const int BASS_ERROR_NOTAVAIL = 37; // requested data/action is not available
    public const int BASS_ERROR_DECODE = 38; // the channel is/isn't a "decoding channel"
    public const int BASS_ERROR_DX = 39; // a sufficient DirectX version is not installed
    public const int BASS_ERROR_TIMEOUT = 40; // connection timedout
    public const int BASS_ERROR_FILEFORM = 41; // unsupported file format
    public const int BASS_ERROR_SPEAKER = 42; // unavailable speaker
    public const int BASS_ERROR_VERSION = 43; // invalid BASS version (used by add-ons)
    public const int BASS_ERROR_CODEC = 44; // codec is not available/supported
    public const int BASS_ERROR_ENDED = 45; // the channel/file has ended
    public const int BASS_ERROR_BUSY = 46; // the device is busy
    public const int BASS_ERROR_UNSTREAMABLE = 47; // unstreamable file
    public const int BASS_ERROR_PROTOCOL = 48; // unsupported protocol
    public const int BASS_ERROR_DENIED = 49; // access denied
    public const int BASS_ERROR_FREEING = 50; // being freed
    public const int BASS_ERROR_CANCEL = 51; // cancelled
    public const int BASS_ERROR_UNKNOWN = -1; // some other mystery problem

    /// <summary>
    /// Converts a raw BASS error integer code into its official bass.h definition name.
    /// </summary>
    public static string GetErrorName(int errorCode)
    {
        return errorCode switch
        {
            BASS_OK => nameof(BASS_OK),
            BASS_ERROR_MEM => nameof(BASS_ERROR_MEM),
            BASS_ERROR_FILEOPEN => nameof(BASS_ERROR_FILEOPEN),
            BASS_ERROR_DRIVER => nameof(BASS_ERROR_DRIVER),
            BASS_ERROR_BUFLOST => nameof(BASS_ERROR_BUFLOST),
            BASS_ERROR_HANDLE => nameof(BASS_ERROR_HANDLE),
            BASS_ERROR_FORMAT => nameof(BASS_ERROR_FORMAT),
            BASS_ERROR_POSITION => nameof(BASS_ERROR_POSITION),
            BASS_ERROR_INIT => nameof(BASS_ERROR_INIT),
            BASS_ERROR_START => nameof(BASS_ERROR_START),
            BASS_ERROR_SSL => nameof(BASS_ERROR_SSL),
            BASS_ERROR_REINIT => nameof(BASS_ERROR_REINIT),
            BASS_ERROR_TRACK => nameof(BASS_ERROR_TRACK),
            BASS_ERROR_ALREADY => nameof(BASS_ERROR_ALREADY),
            BASS_ERROR_NOTAUDIO => nameof(BASS_ERROR_NOTAUDIO),
            BASS_ERROR_NOCHAN => nameof(BASS_ERROR_NOCHAN),
            BASS_ERROR_ILLTYPE => nameof(BASS_ERROR_ILLTYPE),
            BASS_ERROR_ILLPARAM => nameof(BASS_ERROR_ILLPARAM),
            BASS_ERROR_NO3D => nameof(BASS_ERROR_NO3D),
            BASS_ERROR_NOEAX => nameof(BASS_ERROR_NOEAX),
            BASS_ERROR_DEVICE => nameof(BASS_ERROR_DEVICE),
            BASS_ERROR_NOPLAY => nameof(BASS_ERROR_NOPLAY),
            BASS_ERROR_FREQ => nameof(BASS_ERROR_FREQ),
            BASS_ERROR_NOTFILE => nameof(BASS_ERROR_NOTFILE),
            BASS_ERROR_NOHW => nameof(BASS_ERROR_NOHW),
            BASS_ERROR_EMPTY => nameof(BASS_ERROR_EMPTY),
            BASS_ERROR_NONET => nameof(BASS_ERROR_NONET),
            BASS_ERROR_CREATE => nameof(BASS_ERROR_CREATE),
            BASS_ERROR_NOFX => nameof(BASS_ERROR_NOFX),
            BASS_ERROR_NOTAVAIL => nameof(BASS_ERROR_NOTAVAIL),
            BASS_ERROR_DECODE => nameof(BASS_ERROR_DECODE),
            BASS_ERROR_DX => nameof(BASS_ERROR_DX),
            BASS_ERROR_TIMEOUT => nameof(BASS_ERROR_TIMEOUT),
            BASS_ERROR_FILEFORM => nameof(BASS_ERROR_FILEFORM),
            BASS_ERROR_SPEAKER => nameof(BASS_ERROR_SPEAKER),
            BASS_ERROR_VERSION => nameof(BASS_ERROR_VERSION),
            BASS_ERROR_CODEC => nameof(BASS_ERROR_CODEC),
            BASS_ERROR_ENDED => nameof(BASS_ERROR_ENDED),
            BASS_ERROR_BUSY => nameof(BASS_ERROR_BUSY),
            BASS_ERROR_UNSTREAMABLE => nameof(BASS_ERROR_UNSTREAMABLE),
            BASS_ERROR_PROTOCOL => nameof(BASS_ERROR_PROTOCOL),
            BASS_ERROR_DENIED => nameof(BASS_ERROR_DENIED),
            BASS_ERROR_FREEING => nameof(BASS_ERROR_FREEING),
            BASS_ERROR_CANCEL => nameof(BASS_ERROR_CANCEL),
            BASS_ERROR_UNKNOWN => nameof(BASS_ERROR_UNKNOWN),
            _ => $"BASS_ERROR_SPECIFIC_{errorCode}"
        };
    }
}
