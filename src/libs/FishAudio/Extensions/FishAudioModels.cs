#nullable enable

namespace FishAudio;

/// <summary>Canonical Fish Audio text-to-speech model identifiers.</summary>
public static class FishAudioModels
{
    /// <summary>The latest S2.1 Pro model currently exposed by the hosted API.</summary>
    public const string S21ProFree = "s2.1-pro-free";

    /// <summary>The S2.1 Pro model identifier used by enabled paid workspaces.</summary>
    public const string S21Pro = "s2.1-pro";

    /// <summary>The generally available S2 Pro model.</summary>
    public const string S2Pro = "s2-pro";

    /// <summary>The legacy S1 text-to-speech model.</summary>
    public const string S1 = "s1";
}
