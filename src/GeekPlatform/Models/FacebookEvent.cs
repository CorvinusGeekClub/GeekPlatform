using System;
using Newtonsoft.Json;

namespace GeekPlatform.Models
{
    public class FacebookEvent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }
        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }
        public FacebookCoverPhoto Cover { get; set; }
        public FacebookPlace Place { get; set; }
    }
}