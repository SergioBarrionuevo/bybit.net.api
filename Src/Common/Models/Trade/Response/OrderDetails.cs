using Newtonsoft.Json;

namespace bybit.net.api.Models.Trade.Response
{
    public class OrderDetails
    {
        [JsonProperty("orderId")]
        public string? OrderId { get; set; }

        [JsonProperty("orderLinkId")]
        public string? OrderLinkId { get; set; }
    }
}
