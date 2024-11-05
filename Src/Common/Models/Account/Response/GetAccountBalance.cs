using Newtonsoft.Json;

namespace bybit.net.api.Models.Account.Response
{
    public class CoinModel
    {
        [JsonProperty("availableToBorrow")]
        public string AvailableToBorrow { get; set; }

        [JsonProperty("bonus")]
        public string Bonus { get; set; }

        [JsonProperty("accruedInterest")]
        public string AccruedInterest { get; set; }

        [JsonProperty("availableToWithdraw")]
        public string AvailableToWithdraw { get; set; }

        [JsonProperty("totalOrderIM")]
        public string TotalOrderIM { get; set; }

        [JsonProperty("equity")]
        public string Equity { get; set; }

        [JsonProperty("totalPositionMM")]
        public string TotalPositionMM { get; set; }

        [JsonProperty("usdValue")]
        public string UsdValue { get; set; }

        [JsonProperty("unrealisedPnl")]
        public string UnrealisedPnl { get; set; }

        [JsonProperty("collateralSwitch")]
        public bool CollateralSwitch { get; set; }

        [JsonProperty("spotHedgingQty")]
        public string SpotHedgingQty { get; set; }

        [JsonProperty("borrowAmount")]
        public string BorrowAmount { get; set; }

        [JsonProperty("totalPositionIM")]
        public string TotalPositionIM { get; set; }

        [JsonProperty("walletBalance")]
        public string WalletBalance { get; set; }

        [JsonProperty("cumRealisedPnl")]
        public string CumRealisedPnl { get; set; }

        [JsonProperty("locked")]
        public string Locked { get; set; }

        [JsonProperty("marginCollateral")]
        public bool MarginCollateral { get; set; }

        [JsonProperty("coin")]
        public string CoinType { get; set; }
    }

    public class AccountModel
    {
        [JsonProperty("totalEquity")]
        public string TotalEquity { get; set; }

        [JsonProperty("accountIMRate")]
        public string AccountIMRate { get; set; }

        [JsonProperty("totalMarginBalance")]
        public string TotalMarginBalance { get; set; }

        [JsonProperty("totalInitialMargin")]
        public string TotalInitialMargin { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("totalAvailableBalance")]
        public string TotalAvailableBalance { get; set; }

        [JsonProperty("accountMMRate")]
        public string AccountMMRate { get; set; }

        [JsonProperty("totalPerpUPL")]
        public string TotalPerpUPL { get; set; }

        [JsonProperty("totalWalletBalance")]
        public string TotalWalletBalance { get; set; }

        [JsonProperty("accountLTV")]
        public string AccountLTV { get; set; }

        [JsonProperty("totalMaintenanceMargin")]
        public string TotalMaintenanceMargin { get; set; }

        [JsonProperty("coin")]
        public List<CoinModel> Coins { get; set; }
    }

    public class AccountsModel
    {
        [JsonProperty("list")]
        public List<AccountModel> Accounts { get; set; }
    }

    public class WalletBalance
    {
        [JsonProperty("retCode")]
        public int RetCode { get; set; }

        [JsonProperty("retMsg")]
        public string RetMsg { get; set; }

        [JsonProperty("result")]
        public AccountsModel Result { get; set; }

        [JsonProperty("retExtInfo")]
        public Dictionary<string, object> RetExtInfo { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }
    }

}
