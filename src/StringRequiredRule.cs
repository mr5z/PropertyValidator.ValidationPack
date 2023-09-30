using PropertyValidator.Models;

namespace PropertyValidator.ValidationPack
{
    public class StringRequiredRule : ValidationRule<string?>
    {
        public override string ErrorMessage => ErrorMessages.StringRequiredRule;

        public override bool IsValid(string? value)
            => !string.IsNullOrEmpty(value);
    }
}
