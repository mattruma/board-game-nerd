using Bogus;
using System.Threading.Tasks;
using Xunit;

namespace BoardGameNerd.Server.Tests
{
    public abstract class BaseTests : IAsyncLifetime
    {
        protected readonly Faker _faker;

        protected BaseTests()
        {
           _faker = new Faker();
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }

        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
