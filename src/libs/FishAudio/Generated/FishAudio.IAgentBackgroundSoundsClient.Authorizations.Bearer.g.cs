
#nullable enable

namespace FishAudio
{
    public partial interface IAgentBackgroundSoundsClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}