using FluentAssertions;
using System.Runtime.CompilerServices;
using Xunit;

namespace BoardGameNerd.Shared.Tests
{
    public class GameTests : BaseTests
    {
        [Fact]
        public void When_SetProperties()
        {
            // Arrange

            var id = _faker.Random.Number(1000,9999);
            var name = _faker.Lorem.Word();
            var description = _faker.Lorem.Sentence();

            // Action

            var game = new Game()
            {
                Id = id,
                Name = name,
                Description = description
            };

            // Assert

            game.Id.Should().Be(id);
            game.Name.Should().Be(name);
            game.Description.Should().Be(description);
        }
    }
}
