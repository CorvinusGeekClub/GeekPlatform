using Newtonsoft.Json;

namespace GeekPlatform.Models
{
    public class FacebookCoverPhoto
    {
        [JsonProperty("offset_x")]
        public int OffsetX { get; set; }
        [JsonProperty("offset_y")]
        public int OffsetY { get; set; }
        [JsonProperty("source")]
        public string Url { get; set; }
        public string Id { get; set; }
    }
}