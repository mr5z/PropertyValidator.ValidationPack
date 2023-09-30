using PropertyValidator.Models;

namespace PropertyValidator.ValidationPack
{
    public class MinLengthRule : ValidationRule<string?>
    {
        private readonly int minLength;

        public MinLengthRule(int minLength)
        {
            this.minLength = minLength;
        }

        public override string ErrorMessage => string.Format(ErrorMessages.MinLengthRule, minLength);

        public override bool IsValid(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            return value.Length >= minLength;
        }
    }
}
