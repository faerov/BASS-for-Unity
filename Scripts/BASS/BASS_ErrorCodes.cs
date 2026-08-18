public static class BASS_ErrorCodes
{
    public const int BASS_OK = 0;
    public const int BASS_ERROR_MEM = 1;
    public const int BASS_ERROR_FILEOPEN = 2;
    public const int BASS_ERROR_DRIVER = 3;
    public const int BASS_ERROR_HANDLE = 5;
    public const int BASS_ERROR_FORMAT = 6;
    public const int BASS_ERROR_INIT = 8;
    public const int BASS_ERROR_START = 9;
    public const int BASS_ERROR_ALREADY = 14;
    public const int BASS_ERROR_NOTAUDIO = 17;
    public const int BASS_ERROR_UNKNOWN = -1;

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
            BASS_ERROR_HANDLE => nameof(BASS_ERROR_HANDLE),
            BASS_ERROR_FORMAT => nameof(BASS_ERROR_FORMAT),
            BASS_ERROR_INIT => nameof(BASS_ERROR_INIT),
            BASS_ERROR_START => nameof(BASS_ERROR_START),
            BASS_ERROR_ALREADY => nameof(BASS_ERROR_ALREADY),
            BASS_ERROR_NOTAUDIO => nameof(BASS_ERROR_NOTAUDIO),
            BASS_ERROR_UNKNOWN => nameof(BASS_ERROR_UNKNOWN),
            _ => $"BASS_ERROR_SPECIFIC_{errorCode}"
        };
    }
}
