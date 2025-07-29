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

        public List<CandleParser> KlineEntries { get; set; } = new();
        public void ParseKlineEntries()
        {
            KlineEntries = KlineEntriesRaw.Select(CandleParser.FromRaw).ToList();
        }
    }

    public class CandleParser
    {
        public long Timestamp { get; set; }
        public DateTimeOffset Time => DateTimeOffset.FromUnixTimeMilliseconds(Timestamp).ToLocalTime();
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public double Turnover { get; set; }

        public static CandleParser FromRaw(List<string> raw)
        {
            return new CandleParser
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
