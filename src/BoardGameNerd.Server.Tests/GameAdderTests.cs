using FluentAssertions;
using FluentValidation;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BoardGameNerd.Server.Tests
{
    public class GameAdderTests : BaseTests
    {
        [Fact]
        public async void When_ExecuteAsync()
        {
            // Arrange

            var gameAdd = new GameAdd() { Name = _faker.Lorem.Word() };

            var gameAdder = new GameAdder(new GameAddValidator());

            // Action

            Func<Task> action = () => gameAdder.ExecuteAsync(gameAdd);


            // Assert

            await action.Should().NotThrowAsync();
        }

        [Fact]
        public async void When_ExecuteAsync_And_ObjectIsNotValid_Then_ThrowValidationException()
        {
            // Arrange

            var gameAdd = new GameAdd();

            var gameAdder = new GameAdder(new GameAddValidator());

            // Action

            Func<Task> action = () => gameAdder.ExecuteAsync(gameAdd);


            // Assert

            await action.Should().ThrowExactlyAsync<ValidationException>();
        }
    }
}
