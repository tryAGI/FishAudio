#nullable enable

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow(null, FishAudioModels.S2Pro)]
    [DataRow("", FishAudioModels.S2Pro)]
    [DataRow("s1", FishAudioModels.S1)]
    [DataRow("S2Pro", FishAudioModels.S2Pro)]
    [DataRow("s2_1_pro", FishAudioModels.S21Pro)]
    [DataRow("s21-pro-free", FishAudioModels.S21ProFree)]
    public void Models_TryResolve_NormalizesKnownAliases(string? value, string expected)
    {
        FishAudioModels.TryResolve(value, out var actual).Should().BeTrue();
        actual.Should().Be(expected);
    }

    [TestMethod]
    public void Models_TryResolve_RejectsUnknownModel()
    {
        FishAudioModels.TryResolve("future-model", out var actual).Should().BeFalse();
        actual.Should().Be(FishAudioModels.S2Pro);
    }
}
