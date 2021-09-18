namespace Bethselamin.Models
{
    using Newtonsoft.Json;

    public class ToDoListItem
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "who")]
        public string Who { get; set; }

        [JsonProperty(PropertyName = "what")]
        public string What{ get; set; }

        [JsonProperty(PropertyName = "where")]
        public bool Where { get; set; } 

        [JsonProperty(PropertyName = "when")]
        public bool When{ get; set; }

        [JsonProperty(PropertyName = "completed")]
        public bool Completed { get; set; }

    }
}