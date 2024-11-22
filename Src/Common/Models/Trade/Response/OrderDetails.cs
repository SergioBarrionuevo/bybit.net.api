using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Trade.Response
{
    public class OrderCanceledDetail
    {
        [JsonPropertyName("list")]
        public List<OrderDetails> List { get; set; }

        [JsonPropertyName("success")]
        public string Success { get; set; }
    }

    public class OrderDetails
    {
        [JsonPropertyName("orderId")]
        public string? OrderId { get; set; }

        [JsonPropertyName("orderLinkId")]
        public string? OrderLinkId { get; set; }

        public override string ToString()
        {
            return $"OrderId [{OrderId}] LinkId [{OrderLinkId}]";
        }
    }

    public class OrderDataResponse
    {
        [JsonPropertyName("nextPageCursor")]
        public string NextPageCursor { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("list")]
        public List<OrderData> List { get; set; }
    }

    public class OrderData
    {
        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("orderId")]
        public string OrderId { get; set; }

        [JsonPropertyName("orderLinkId")]
        public string OrderLinkId { get; set; }

        [JsonPropertyName("blockTradeId")]
        public string BlockTradeId { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }

        [JsonPropertyName("positionIdx")]
        public int PositionIdx { get; set; }

        [JsonPropertyName("orderStatus")]
        public string OrderStatus { get; set; }

        [JsonPropertyName("cancelType")]
        public string CancelType { get; set; }

        [JsonPropertyName("rejectReason")]
        public string RejectReason { get; set; }

        [JsonPropertyName("timeInForce")]
        public string TimeInForce { get; set; }

        [JsonPropertyName("isLeverage")]
        public string IsLeverage { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("qty")]
        public string Qty { get; set; }

        [JsonPropertyName("avgPrice")]
        public string AvgPrice { get; set; }

        [JsonPropertyName("leavesQty")]
        public string LeavesQty { get; set; }

        [JsonPropertyName("leavesValue")]
        public string LeavesValue { get; set; }

        [JsonPropertyName("cumExecQty")]
        public string CumExecQty { get; set; }

        [JsonPropertyName("cumExecValue")]
        public string CumExecValue { get; set; }

        [JsonPropertyName("cumExecFee")]
        public string CumExecFee { get; set; }

        [JsonPropertyName("orderType")]
        public string OrderType { get; set; }

        [JsonPropertyName("stopOrderType")]
        public string StopOrderType { get; set; }

        [JsonPropertyName("orderIv")]
        public string OrderIv { get; set; }

        [JsonPropertyName("triggerPrice")]
        public string TriggerPrice { get; set; }

        [JsonPropertyName("takeProfit")]
        public string TakeProfit { get; set; }

        [JsonPropertyName("stopLoss")]
        public string StopLoss { get; set; }

        [JsonPropertyName("triggerBy")]
        public string TriggerBy { get; set; }

        [JsonPropertyName("tpTriggerBy")]
        public string TpTriggerBy { get; set; }

        [JsonPropertyName("slTriggerBy")]
        public string SlTriggerBy { get; set; }

        [JsonPropertyName("triggerDirection")]
        public int TriggerDirection { get; set; }

        [JsonPropertyName("placeType")]
        public string PlaceType { get; set; }

        [JsonPropertyName("lastPriceOnCreated")]
        public string LastPriceOnCreated { get; set; }

        [JsonPropertyName("closeOnTrigger")]
        public bool CloseOnTrigger { get; set; }

        [JsonPropertyName("reduceOnly")]
        public bool ReduceOnly { get; set; }

        [JsonPropertyName("smpGroup")]
        public int SmpGroup { get; set; }

        [JsonPropertyName("smpType")]
        public string SmpType { get; set; }

        [JsonPropertyName("smpOrderId")]
        public string SmpOrderId { get; set; }

        [JsonPropertyName("slLimitPrice")]
        public string SlLimitPrice { get; set; }

        [JsonPropertyName("tpLimitPrice")]
        public string TpLimitPrice { get; set; }

        [JsonPropertyName("tpslMode")]
        public string TpslMode { get; set; }

        [JsonPropertyName("createType")]
        public string CreateType { get; set; }

        [JsonPropertyName("marketUnit")]
        public string MarketUnit { get; set; }

        [JsonPropertyName("createdTime")]
        public long CreatedTime { get; set; }

        [JsonPropertyName("updatedTime")]
        public long UpdatedTime { get; set; }

        [JsonPropertyName("feeCurrency")]
        public string FeeCurrency { get; set; }
    }

}
