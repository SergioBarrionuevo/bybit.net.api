using System.Text.Json.Serialization;

namespace bybit.net.api.Models.Account.Response
{

    public class Coin
    {
        [JsonPropertyName("availableToBorrow")]
        public string AvailableToBorrow { get; set; } = string.Empty;

        [JsonPropertyName("bonus")]
        public string Bonus { get; set; } = string.Empty;

        [JsonPropertyName("accruedInterest")]
        public string AccruedInterest { get; set; } = string.Empty;

        [JsonPropertyName("availableToWithdraw")]
        public string AvailableToWithdraw { get; set; } = string.Empty;

        [JsonPropertyName("totalOrderIM")]
        public string TotalOrderIM { get; set; } = string.Empty;

        [JsonPropertyName("equity")]
        public string Equity { get; set; } = string.Empty;

        [JsonPropertyName("totalPositionMM")]
        public string TotalPositionMM { get; set; } = string.Empty;

        [JsonPropertyName("usdValue")]
        public string UsdValue { get; set; } = string.Empty;

        [JsonPropertyName("unrealisedPnl")]
        public string UnrealisedPnl { get; set; } = string.Empty;

        [JsonPropertyName("collateralSwitch")]
        public bool CollateralSwitch { get; set; }

        [JsonPropertyName("spotHedgingQty")]
        public string SpotHedgingQty { get; set; } = string.Empty;

        [JsonPropertyName("borrowAmount")]
        public string BorrowAmount { get; set; } = string.Empty;

        [JsonPropertyName("totalPositionIM")]
        public string TotalPositionIM { get; set; } = string.Empty;

        [JsonPropertyName("walletBalance")]
        public string WalletBalance { get; set; } = string.Empty;

        [JsonPropertyName("cumRealisedPnl")]
        public string CumRealisedPnl { get; set; } = string.Empty;

        [JsonPropertyName("locked")]
        public string Locked { get; set; } = string.Empty;

        [JsonPropertyName("marginCollateral")]
        public bool MarginCollateral { get; set; }

        [JsonPropertyName("coin")]
        public string CoinType { get; set; } = string.Empty;
    }

    public class AccountInfo
    {
        [JsonPropertyName("totalEquity")]
        public string TotalEquity { get; set; } = string.Empty;

        [JsonPropertyName("accountIMRate")]
        public string AccountIMRate { get; set; } = string.Empty;

        [JsonPropertyName("totalMarginBalance")]
        public string TotalMarginBalance { get; set; } = string.Empty;

        [JsonPropertyName("totalInitialMargin")]
        public string TotalInitialMargin { get; set; } = string.Empty;

        [JsonPropertyName("accountType")]
        public string AccountType { get; set; } = string.Empty;

        [JsonPropertyName("totalAvailableBalance")]
        public string TotalAvailableBalance { get; set; } = string.Empty;

        [JsonPropertyName("accountMMRate")]
        public string AccountMMRate { get; set; } = string.Empty;

        [JsonPropertyName("totalPerpUPL")]
        public string TotalPerpUPL { get; set; } = string.Empty;

        [JsonPropertyName("totalWalletBalance")]
        public string TotalWalletBalance { get; set; } = string.Empty;

        [JsonPropertyName("accountLTV")]
        public string AccountLTV { get; set; } = string.Empty;

        [JsonPropertyName("totalMaintenanceMargin")]
        public string TotalMaintenanceMargin { get; set; } = string.Empty;

        [JsonPropertyName("coin")]
        public List<Coin> Coins { get; set; } = new();
    }

    public class AccountDataResponse
    {
        [JsonPropertyName("list")]
        public List<AccountInfo> List { get; set; } = new();
    }


}
