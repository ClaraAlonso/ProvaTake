using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaTake.Domain.Models
{
    public partial class Repositorio
    {
        [JsonProperty("itemType")]
        public string ItemType { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("header")]
        public Header Header { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public HeaderValue Value { get; set; }
    }

    public partial class HeaderValue
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public Uri Uri { get; set; }
    }
}
