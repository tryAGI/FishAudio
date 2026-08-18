#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneNumbersDeleteAgentPhoneNumbersByPhoneNumberIdCommandApiCommand
{
    private static Argument<string> PhoneNumberId { get; } = new(
        name: @"phone-number-id")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-agent-phone-numbers-by-phone-number-id", @"Release Phone Number
Release a number back to the provider's inventory and stop its daily
billing. This is irreversible: anyone (including other platforms) can
buy the number afterwards, so callers who saved it may reach a stranger.
The number disappears from this API immediately.");
                        command.Arguments.Add(PhoneNumberId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var phoneNumberId = parseResult.GetRequiredValue(PhoneNumberId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.PhoneNumbers.DeleteAgentPhoneNumbersByPhoneNumberIdAsync(
                                    phoneNumberId: phoneNumberId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}