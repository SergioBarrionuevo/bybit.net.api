using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Position.Response
{
    public class PositionResponse
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

        [JsonPropertyName("leverage")]
        public string Leverage { get; set; }

        [JsonPropertyName("autoAddMargin")]
        public int AutoAddMargin { get; set; }

        [JsonPropertyName("avgPrice")]
        public string AvgPrice { get; set; }

        [JsonPropertyName("liqPrice")]
        public string LiqPrice { get; set; }

        [JsonPropertyName("riskLimitValue")]
        public string RiskLimitValue { get; set; }

        [JsonPropertyName("takeProfit")]
        public string TakeProfit { get; set; }

        [JsonPropertyName("positionValue")]
        public string PositionValue { get; set; }

        [JsonPropertyName("isReduceOnly")]
        public bool IsReduceOnly { get; set; }

        [JsonPropertyName("tpslMode")]
        public string TpslMode { get; set; }

        [JsonPropertyName("riskId")]
        public int RiskId { get; set; }

        [JsonPropertyName("trailingStop")]
        public string TrailingStop { get; set; }

        [JsonPropertyName("unrealisedPnl")]
        public string UnrealisedPnl { get; set; }

        [JsonPropertyName("markPrice")]
        public string MarkPrice { get; set; }

        [JsonPropertyName("adlRankIndicator")]
        public int AdlRankIndicator { get; set; }

        [JsonPropertyName("cumRealisedPnl")]
        public string CumRealisedPnl { get; set; }

        [JsonPropertyName("positionMM")]
        public string PositionMM { get; set; }

        [JsonPropertyName("createdTime")]
        public long CreatedTime { get; set; }

        [JsonPropertyName("positionIdx")]
        public int PositionIdx { get; set; }

        [JsonPropertyName("positionIM")]
        public string PositionIM { get; set; }

        [JsonPropertyName("seq")]
        public long Seq { get; set; }

        [JsonPropertyName("updatedTime")]
        public long UpdatedTime { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }

        [JsonPropertyName("bustPrice")]
        public string BustPrice { get; set; }

        [JsonPropertyName("positionBalance")]
        public string PositionBalance { get; set; }

        [JsonPropertyName("leverageSysUpdatedTime")]
        public string LeverageSysUpdatedTime { get; set; }

        [JsonPropertyName("curRealisedPnl")]
        public string CurRealisedPnl { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("positionStatus")]
        public string PositionStatus { get; set; }

        [JsonPropertyName("mmrSysUpdatedTime")]
        public string MmrSysUpdatedTime { get; set; }

        [JsonPropertyName("stopLoss")]
        public string StopLoss { get; set; }

        [JsonPropertyName("tradeMode")]
        public int TradeMode { get; set; }

        [JsonPropertyName("sessionAvgPrice")]
        public string SessionAvgPrice { get; set; }
    }

}
