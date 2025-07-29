using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Market.Response
{
    public class KlineEntry1
    {
        [JsonPropertyOrder(1)]
        public string? StartTime { get; set; }

        [JsonPropertyOrder(2)]
        public string? OpenPrice { get; set; }

        [JsonPropertyOrder(3)]
        public string? HighPrice { get; set; }

        [JsonPropertyOrder(4)]
        public string? LowPrice { get; set; }

        [JsonPropertyOrder(5)]
        public string? ClosePrice { get; set; }

        [JsonPropertyOrder(6)]
        public string? Volume { get; set; }

        [JsonPropertyOrder(7)]
        public string? Turnover { get; set; }
    }
}