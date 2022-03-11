using FluentValidation;

namespace BoardGameNerd.Server
{
    public class GameAddValidator : AbstractValidator<GameAdd>
    {
        public GameAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
