using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Position.Response
{

    public class PositionDataResponse
    {
        [JsonPropertyName("nextPageCursor")]
        public string NextPageCursor { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("list")]
        public List<PositionDetail> List { get; set; }
    }

    public class PositionDetail
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("orderType")]
        public string OrderType { get; set; }

        [JsonPropertyName("leverage")]
        public string Leverage { get; set; }

        [JsonPropertyName("updatedTime")]
        public string UpdatedTime { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }

        [JsonPropertyName("orderId")]
        public string OrderId { get; set; }

        [JsonPropertyName("closedPnl")]
        public double ClosedPnl { get; set; }

        [JsonPropertyName("avgEntryPrice")]
        public string AvgEntryPrice { get; set; }

        [JsonPropertyName("qty")]
        public string Qty { get; set; }

        [JsonPropertyName("cumEntryValue")]
        public string CumEntryValue { get; set; }

        [JsonPropertyName("createdTime")]
        public string CreatedTime { get; set; }

        [JsonPropertyName("orderPrice")]
        public string OrderPrice { get; set; }

        [JsonPropertyName("closedSize")]
        public string ClosedSize { get; set; }

        [JsonPropertyName("avgExitPrice")]
        public string AvgExitPrice { get; set; }

        [JsonPropertyName("execType")]
        public string ExecType { get; set; }

        [JsonPropertyName("fillCount")]
        public string FillCount { get; set; }

        [JsonPropertyName("cumExitValue")]
        public string CumExitValue { get; set; }
    }

}
