using System.Text.Json.Serialization;

namespace bybit.net.api.Models
{
    public class GeneralResponse<T>
    {
        [JsonPropertyName("retCode")]
        public int? RetCode { get; set; }

        [JsonPropertyName("retMsg")]
        public string RetMsg { get; set; } = "";

        [JsonPropertyName("result")]
        public T? Data { get; set; }

        [JsonPropertyName("retExtInfo")]
        public Dictionary<string, object>? RetExtInfo { get; set; }

        [JsonPropertyName("time")]
        public long Time { get; set; }

        public DateTimeOffset TimeStamp => DateTimeOffset.FromUnixTimeMilliseconds(Time).ToLocalTime();

        public bool IsOk => RetMsg == MessageConstants.Ok;

        public override string ToString()
        {
            return $"Msg [{RetMsg}] Code [{RetCode}] Time [{TimeStamp}] Data [{Data}]";
        }
    }
}
