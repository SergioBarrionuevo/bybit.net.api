using bybit.net.api.Websockets;
using System.Net.WebSockets;

namespace bybit.net.api.WebSocketStream
{
    public class BybitLinearWebSocket : BybitWebSocket
    {
        public BybitLinearWebSocket(BybitNetType netType = BybitNetType.MainNet, int pingInterval = 20, int receiveBufferSize = 8192, string? apiKey = null, string? apiSecret = null, bool debugMode = false)
            : base(new BybitWebSocketHandler(new ClientWebSocket()), GetStreamUrl(netType), pingInterval, receiveBufferSize, apiKey, apiSecret, debugMode)
        {
        }

        public BybitLinearWebSocket(IBybitWebSocketHandler handler, BybitNetType netType = BybitNetType.MainNet, int pingInterval = 20, int receiveBufferSize = 8192, string? apiKey = null, string? apiSecret = null, bool debugMode = false)
            : base(handler, GetStreamUrl(netType), pingInterval, receiveBufferSize, apiKey, apiSecret, debugMode)
        {
        }

        private static string GetStreamUrl(BybitNetType netType)
        {
            switch (netType)
            {
                case BybitNetType.MainNet:
                case BybitNetType.MainNetDemo:
                    return BybitConstants.LINEAR_MAINNET;
                case BybitNetType.TestNet:
                    return BybitConstants.LINEAR_TESTNET;
                default:
                    throw new ArgumentOutOfRangeException(nameof(netType), netType, null);
            }
        }
    }
}
