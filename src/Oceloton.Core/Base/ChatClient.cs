using Oceloton.Domain.Constants;
using Oceloton.Domain.Models;

namespace Oceloton.Core.Base
{
    public class ChatClient
    {
        public delegate void MessageHandler(Message message);
        private readonly string _host;
        private readonly int _port;
        private readonly int _ttl;
        public ChatClient()
        {
            _host = ChatConstants.HOST;
            _port = ChatConstants.PORT;
            _ttl = ChatConstants.TTL;
        }

        public ChatClient(string host, int port, int ttl)
        {
            _host = host;
            _port = port;
            _ttl = ttl;
        }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}