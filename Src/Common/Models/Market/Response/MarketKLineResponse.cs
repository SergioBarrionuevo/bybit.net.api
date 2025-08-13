using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Market.Response
{
    public class MarketKLineResponse
    {
        [JsonPropertyName("category")]
        public String? Category { get; set; }

        [JsonPropertyName("symbol")]
        public String? Symbol { get; set; }

        [JsonPropertyName("list")]
        public List<List<string>> KlineEntriesRaw { get; set; } = new();

        private readonly Lazy<List<CandleData>> klineEntries;
        public List<CandleData> KlineEntries => klineEntries.Value;

        public MarketKLineResponse()
        {
            klineEntries = new(() => KlineEntriesRaw.Select(CandleData.FromRaw).ToList());
        }
    }

    public class CandleData
    {
        public long Timestamp { get; set; }
        public DateTimeOffset Time => DateTimeOffset.FromUnixTimeMilliseconds(Timestamp).ToLocalTime();
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public double Turnover { get; set; }

        public override string ToString()
        {
            return $"{Time} low {Low} open {Open} close {Close} high {High} vol {Volume}";
        }

        public static CandleData FromRaw(List<string> raw)
        {
            return new CandleData
            {
                Timestamp = long.Parse(raw[0]),
                Open = double.Parse(raw[1]),
                High = double.Parse(raw[2]),
                Low = double.Parse(raw[3]),
                Close = double.Parse(raw[4]),
                Volume = double.Parse(raw[5]),
                Turnover = double.Parse(raw[6])
            };
        }
    }
}
