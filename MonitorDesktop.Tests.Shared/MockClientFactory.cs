using MonitorDesktop.Api;

namespace MonitorDesktop.Tests.Shared
{
    public class MockClientFactory : IConnectionFactory<MockClient>
    {
        private readonly int _messagesCount;

        public MockClientFactory(int messagesCount)
        {
            _messagesCount = messagesCount;
        }

        public MockClient Create() => new MockClient(_messagesCount);
    }
}