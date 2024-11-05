using bybit.net.api.Websockets;
using System.Net.WebSockets;

namespace bybit.net.api.WebSocketStream
{
    public class BybitPrivateWebsocket : BybitWebSocket
    {
        public BybitPrivateWebsocket(string apiKey, string apiSecret, BybitNetType netType = BybitNetType.MainNet, int pingInterval = 20, int receiveBufferSize = 8192, string? maxAliveTime = null, bool debugMode = false)
            : base(new BybitWebSocketHandler(new ClientWebSocket()), GetStreamUrl(netType), pingInterval, receiveBufferSize, apiKey, apiSecret, debugMode, maxAliveTime)
        {
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret))
            {
                throw new BybitClientException("API key and API secret are required for private websocket channel", -1);
            }
        }

        public BybitPrivateWebsocket(IBybitWebSocketHandler handler, string apiKey, string apiSecret, BybitNetType netType = BybitNetType.MainNet, int pingInterval = 20, int receiveBufferSize = 8192, string? maxAliveTime = null, bool debugMode = false)
            : base(handler, GetStreamUrl(netType), pingInterval, receiveBufferSize, apiKey, apiSecret, debugMode, maxAliveTime)
        {
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret))
            {
                throw new BybitClientException("API key and API secret are required for private websocket channel", -1);
            }
        }

        private static string GetStreamUrl(BybitNetType netType)
        {
            switch (netType)
            {
                case BybitNetType.MainNet:
                    return BybitConstants.WEBSOCKET_PRIVATE_MAINNET;
                case BybitNetType.MainNetDemo:
                    return BybitConstants.WEBSOCKET_PRIVATE_MAINNET_DEMO;
                case BybitNetType.TestNet:
                    return BybitConstants.WEBSOCKET_PRIVATE_TESTNET;
                default:
                    throw new ArgumentOutOfRangeException(nameof(netType), netType, null);
            }
        }
    }
}
