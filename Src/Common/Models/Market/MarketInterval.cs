namespace bybit.net.api.Models.Market
{
    public struct MarketInterval
    {
        public string Value { get; private set; }

        private MarketInterval(string interval) => Value = interval;

        public static MarketInterval OneMinute => new("1");
        public static MarketInterval ThreeMinutes => new("3");
        public static MarketInterval FiveMinutes => new("5");
        public static MarketInterval FifteenMinutes => new("15");
        public static MarketInterval ThirtyMinutes => new("30");
        public static MarketInterval OneHour => new("60");
        public static MarketInterval TwoHours => new("120");
        public static MarketInterval FourHours => new("240");
        public static MarketInterval SixHours => new("360");
        public static MarketInterval TwelveHours => new("720");
        public static MarketInterval Daily => new("D");
        public static MarketInterval Monthly => new("M");
        public static MarketInterval Weekly => new("W");

        public override readonly string ToString() => Value;
        public static implicit operator string(MarketInterval interval) => interval.Value;
    }

    public static class MarketIntervalConverter
    {
        public static MarketInterval Convert(float input)
        {
            switch (input)
            {
                case 1f:
                    return MarketInterval.OneMinute;
                case 3f:
                    return MarketInterval.ThreeMinutes;
                case 5f:
                    return MarketInterval.FiveMinutes;
                case 15f:
                    return MarketInterval.FifteenMinutes;
                case 30f:
                    return MarketInterval.ThirtyMinutes;
                case 60f:
                    return MarketInterval.OneHour;
                case 120f:
                    return MarketInterval.TwoHours;
                case 240f:
                    return MarketInterval.FourHours;
                case 360f:
                    return MarketInterval.SixHours;
                case 720f:
                    return MarketInterval.TwelveHours;
                case 1440f:
                    return MarketInterval.Daily;
                case 10080f:
                    return MarketInterval.Weekly;
                case 302400f:
                    return MarketInterval.Monthly;
                default:
                    return new MarketInterval();
            }
        }

    }
}
