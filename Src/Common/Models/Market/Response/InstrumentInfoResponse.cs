using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Market.Response
{
    public class InstrumentInfoResponse
    {
        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("list")]
        public List<ContractDetails> List { get; set; }

        [JsonPropertyName("nextPageCursor")]
        public string NextPageCursor { get; set; }
    }

    public class ContractDetails
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("contractType")]
        public string ContractType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("baseCoin")]
        public string BaseCoin { get; set; }

        [JsonPropertyName("quoteCoin")]
        public string QuoteCoin { get; set; }

        [JsonPropertyName("launchTime")]
        public string LaunchTime { get; set; }

        [JsonPropertyName("deliveryTime")]
        public string DeliveryTime { get; set; }

        [JsonPropertyName("deliveryFeeRate")]
        public string DeliveryFeeRate { get; set; }

        [JsonPropertyName("priceScale")]
        public string PriceScale { get; set; }

        [JsonPropertyName("leverageFilter")]
        public LeverageFilter LeverageFilter { get; set; }

        [JsonPropertyName("priceFilter")]
        public PriceFilter PriceFilter { get; set; }

        [JsonPropertyName("lotSizeFilter")]
        public LotSizeFilter LotSizeFilter { get; set; }

        [JsonPropertyName("unifiedMarginTrade")]
        public bool UnifiedMarginTrade { get; set; }

        [JsonPropertyName("fundingInterval")]
        public int FundingInterval { get; set; }

        [JsonPropertyName("settleCoin")]
        public string SettleCoin { get; set; }

        [JsonPropertyName("copyTrading")]
        public string CopyTrading { get; set; }

        [JsonPropertyName("upperFundingRate")]
        public string UpperFundingRate { get; set; }

        [JsonPropertyName("lowerFundingRate")]
        public string LowerFundingRate { get; set; }

        [JsonPropertyName("isPreListing")]
        public bool IsPreListing { get; set; }

        [JsonPropertyName("preListingInfo")]
        public object PreListingInfo { get; set; }
    }

    public class LeverageFilter
    {
        [JsonPropertyName("minLeverage")]
        public double MinLeverage { get; set; }

        [JsonPropertyName("maxLeverage")]
        public double MaxLeverage { get; set; }

        [JsonPropertyName("leverageStep")]
        public string LeverageStep { get; set; }
    }

    public class PriceFilter
    {
        [JsonPropertyName("minPrice")]
        public double MinPrice { get; set; }

        [JsonPropertyName("maxPrice")]
        public double MaxPrice { get; set; }

        [JsonPropertyName("tickSize")]
        public string TickSize { get; set; }
    }

    public class LotSizeFilter
    {
        [JsonPropertyName("maxOrderQty")]
        public double MaxOrderQty { get; set; }

        [JsonPropertyName("minOrderQty")]
        public double MinOrderQty { get; set; }

        [JsonPropertyName("qtyStep")]
        public string QtyStep { get; set; }

        [JsonPropertyName("postOnlyMaxOrderQty")]
        public string PostOnlyMaxOrderQty { get; set; }

        [JsonPropertyName("maxMktOrderQty")]
        public string MaxMktOrderQty { get; set; }

        [JsonPropertyName("minNotionalValue")]
        public string MinNotionalValue { get; set; }
    }

}
