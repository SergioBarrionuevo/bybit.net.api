﻿using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Position.Response
{

    public class ProfitAndLossResponse
    {
        [JsonPropertyName("nextPageCursor")]
        public string NextPageCursor { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("list")]
        public List<ProfitAndLossDetail> List { get; set; }
    }

    public class ProfitAndLossDetail
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

        public override string ToString()
        {
            return $"{nameof(Symbol)}: {Symbol}, {nameof(OrderType)}: {OrderType}, {nameof(Leverage)}: {Leverage}, {nameof(UpdatedTime)}: {UpdatedTime}, {nameof(Side)}: {Side}, {nameof(OrderId)}: {OrderId}, {nameof(ClosedPnl)}: {ClosedPnl}, {nameof(AvgEntryPrice)}: {AvgEntryPrice}, {nameof(Qty)}: {Qty}, {nameof(CumEntryValue)}: {CumEntryValue}, {nameof(CreatedTime)}: {CreatedTime}, {nameof(OrderPrice)}: {OrderPrice}, {nameof(ClosedSize)}: {ClosedSize}, {nameof(AvgExitPrice)}: {AvgExitPrice}, {nameof(ExecType)}: {ExecType}, {nameof(FillCount)}: {FillCount}, {nameof(CumExitValue)}: {CumExitValue}";
        }
    }

}
