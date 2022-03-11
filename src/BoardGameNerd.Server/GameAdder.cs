using BoardGameNerd.Shared;
using FluentValidation;

namespace BoardGameNerd.Server
{
    public class GameAdder
    {
        private readonly IValidator<GameAdd> _validator;

        public GameAdder(IValidator<GameAdd> validator)
        {
            _validator = validator;
        }

        public async Task<Game> ExecuteAsync(GameAdd gameAdd)
        {
            var validationResult = await _validator.ValidateAsync(gameAdd);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            return new Game { Name = gameAdd.Name };
        }
    }
}
