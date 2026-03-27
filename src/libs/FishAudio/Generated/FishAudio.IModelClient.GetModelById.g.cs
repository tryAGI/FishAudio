#nullable enable

namespace FishAudio
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetModelResponse2> GetModelByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}