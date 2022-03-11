using FluentAssertions;
using FluentValidation;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BoardGameNerd.Server.Tests
{
    public class GameValidatorTests : BaseTests
    {
        [Fact]
        public async void When_ValidateAndThrowAsync()
        {
            // Arrange

            var gameAdd = new GameAdd() { Name = _faker.Lorem.Word() };

            var gameAddValidator = new GameAddValidator();

            // Action

            Func<Task> action = () => gameAddValidator.ValidateAndThrowAsync(gameAdd);


            // Assert

            await action.Should().NotThrowAsync();
        }

        [Fact]
        public async void When_ValidateAndThrowAsync_And_NameIsNull_Then_ThrowValidationException()
        {
            // Arrange

            var gameAdd = new GameAdd();

            var gameAddValidator = new GameAddValidator();

            // Action

            Func<Task> action = () => gameAddValidator.ValidateAndThrowAsync(gameAdd);


            // Assert

            await action.Should().ThrowExactlyAsync<ValidationException>();
        }

        [Fact]
        public async void When_ValidateAndThrowAsync_And_NameIsEmpty_Then_ThrowValidationException()
        {
            // Arrange

            var gameAdd = new GameAdd() { Name = String.Empty };

            var gameAddValidator = new GameAddValidator();

            // Action

            Func<Task> action = () => gameAddValidator.ValidateAndThrowAsync(gameAdd);


            // Assert

            await action.Should().ThrowExactlyAsync<ValidationException>();
        }
    }
}
