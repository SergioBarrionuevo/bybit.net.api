using Newtonsoft.Json;

namespace bybit.net.api.Models.Trade.Response
{
    public class OrderResult
    {
        [JsonProperty("retCode")]
        public int? RetCode { get; set; }

        [JsonProperty("retMsg")]
        public string? RetMsg { get; set; }

        [JsonProperty("result")]
        public OrderDetails? Details { get; set; }

        [JsonProperty("retExtInfo")]
        public Dictionary<string, object>? RetExtInfo { get; set; } = [];

        [JsonProperty("time")]
        public long Time { get; set; }

        public DateTimeOffset TimeStamp => DateTimeOffset.FromUnixTimeMilliseconds(Time).ToLocalTime();

        public bool IsOk => RetMsg == MessageConstants.Ok;

        public override string ToString()
        {
            return $"Msg [{RetMsg}] Code [{RetCode}] OrderId [{Details?.OrderId}] LinkId [{Details?.OrderLinkId}] Time [{TimeStamp}]";
        }
    }


    public class CancelAllOrdersResponse
    {
        [JsonProperty("retCode")]
        public int RetCode { get; set; }

        [JsonProperty("retMsg")]
        public string RetMsg { get; set; }

        [JsonProperty("result")]
        public OrderCanceledDetail Result { get; set; }

        [JsonProperty("retExtInfo")]
        public RetExtInfo RetExtInfo { get; set; }

        public bool IsOk => RetMsg == MessageConstants.Ok;

        [JsonProperty("time")]
        public long Time { get; set; }
    }

    public class OrderCanceledDetail
    {
        [JsonProperty("list")]
        public List<OrderDetails> List { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }
    }

    public class RetExtInfo
    {
        // If retExtInfo has additional fields, define them here.
    }

}