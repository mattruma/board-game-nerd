using FluentValidation;

namespace BoardGameNerd.Shared
{
    public class GameAddValidator : AbstractValidator<GameAdd>
    {
        public GameAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
