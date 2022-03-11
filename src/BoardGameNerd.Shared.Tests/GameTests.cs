using FluentAssertions;
using Xunit;

namespace BoardGameNerd.Shared.Tests
{
    public class GameAddTests : BaseTests
    {
        [Fact]
        public void When_SetProperties()
        {
            // Arrange

            var name = _faker.Lorem.Word();

            // Action

            var gameAdd = new GameAdd()
            {
                Name = name
            };

            // Assert

            gameAdd.Name.Should().Be(name);
        }
    }
}
