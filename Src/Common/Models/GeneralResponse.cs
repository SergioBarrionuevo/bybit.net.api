using Newtonsoft.Json;

namespace bybit.net.api.Models
{
    public class GeneralResponse<T>
    {
        [JsonProperty("retCode")]
        public int? RetCode { get; set; }

        [JsonProperty("retMsg")]
        public string RetMsg { get; set; } = "";

        [JsonProperty("result")]
        public T? Result { get; set; }

        [JsonProperty("retExtInfo")]
        public Dictionary<string, object>? RetExtInfo { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        public DateTimeOffset TimeStamp => DateTimeOffset.FromUnixTimeMilliseconds(Time).ToLocalTime();

        public bool IsOk => RetMsg == MessageConstants.Ok;

        public override string ToString()
        {
            return $"Msg [{RetMsg}] Code [{RetCode}] Time [{TimeStamp}]";
        }
    }
}
