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

    /// <summary>
    /// Resolves a canonical model id from the common punctuation-free and separator variants
    /// used by configuration systems. Empty input selects <see cref="S2Pro" />.
    /// </summary>
    public static bool TryResolve(string? value, out string modelId)
    {
        modelId = S2Pro;
        if (string.IsNullOrWhiteSpace(value))
        {
            return true;
        }

        switch (value.Trim().ToUpperInvariant())
        {
            case "S1":
                modelId = S1;
                return true;
            case "S2-PRO":
            case "S2PRO":
            case "S2_PRO":
                modelId = S2Pro;
                return true;
            case "S2.1-PRO":
            case "S21-PRO":
            case "S2_1_PRO":
            case "S2-1-PRO":
                modelId = S21Pro;
                return true;
            case "S2.1-PRO-FREE":
            case "S21-PRO-FREE":
            case "S2_1_PRO_FREE":
            case "S2-1-PRO-FREE":
                modelId = S21ProFree;
                return true;
            default:
                return false;
        }
    }
}
