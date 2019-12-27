using System;
using System.Threading;
using MonitorDesktop.Api;

namespace MonitorDesktop.Tests.Shared
{
    public class MockReceivingServerFactory : IConnectionFactory<MockReceivingServer>
    {
        private readonly TimeSpan _messageInterval;
        private readonly int _messageCount;

        public MockReceivingServerFactory(TimeSpan messageInterval, int messageCount)
        {
            _messageInterval = messageInterval;
            _messageCount = messageCount;
        }

        public MockReceivingServer Create() => new MockReceivingServer(_messageInterval, _messageCount);
    }
}