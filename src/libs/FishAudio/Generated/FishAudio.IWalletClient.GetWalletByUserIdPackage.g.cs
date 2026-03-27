#nullable enable

namespace FishAudio
{
    public partial interface IWalletClient
    {
        /// <summary>
        /// Get User Package
        /// </summary>
        /// <param name="userId">
        /// Default Value: self
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetWalletPackageResponse> GetWalletByUserIdPackageAsync(
            string? userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}