#nullable enable

using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace FishAudio.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ModelClient_CreateModel_SendsMultipartBinaryParts()
    {
        var handler = new StaticResponseHandler(
            new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent("{\"detail\":\"request captured\"}", Encoding.UTF8, "application/json"),
            });
        using var client = new FishAudioClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(FishAudioClient.DefaultBaseUrl),
            });
        var request = new CreateModelRequest3
        {
            Title = "Multipart model",
            Voices = new List<byte[]>
            {
                new byte[] { 1, 2, 3 },
                new byte[] { 4, 5, 6 },
            },
        };

        var action = () => client.Model.CreateModelAsync(request);

        await action.Should().ThrowAsync<ApiException>();
        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsolutePath.Should().Be("/model");
        handler.LastRequest.Content!.Headers.ContentType!.MediaType.Should().Be("multipart/form-data");
        handler.LastRequestBody.Should().Contain("name=\"title\"");
        handler.LastRequestBody.Should().Contain("Multipart model");
        Regex.Matches(handler.LastRequestBody!, "name=\"voices\"").Should().HaveCount(2);
        Regex.Matches(handler.LastRequestBody!, "filename=\"file[01]\\.bin\"").Should().HaveCount(2);
    }

    [TestMethod]
    [DataRow(true, "/wallet/self/api-credit", "check_free_credit=true")]
    [DataRow(false, "/wallet/self/package", null)]
    public async Task WalletClient_SupportsAuthenticatedSelfEndpoints(
        bool apiCredit,
        string expectedPath,
        string? expectedQuery)
    {
        var handler = new StaticResponseHandler(
            new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent("{\"detail\":\"request captured\"}", Encoding.UTF8, "application/json"),
            });
        using var client = new FishAudioClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(FishAudioClient.DefaultBaseUrl),
            });

        Func<Task> action = apiCredit
            ? async () => await client.Wallet.GetWalletByUserIdApiCreditAsync(
                userId: "self",
                checkFreeCredit: true)
            : async () => await client.Wallet.GetWalletByUserIdPackageAsync(userId: "self");

        await action.Should().ThrowAsync<ApiException>();
        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsolutePath.Should().Be(expectedPath);
        if (expectedQuery is not null)
        {
            handler.LastRequest.RequestUri.Query.Should().Contain(expectedQuery);
        }
        handler.LastRequest.Headers.Authorization!.Scheme.Should().Be("Bearer");
        handler.LastRequest.Headers.Authorization.Parameter.Should().Be("test-api-key");
    }
}
