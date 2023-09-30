using PropertyValidator.Models;

namespace PropertyValidator.ValidationPack
{
    public class MaxLengthRule : ValidationRule<string?>
    {
        private readonly int maxLength;

        public MaxLengthRule(int maxLength)
        {
            this.maxLength = maxLength;
        }

        public override string ErrorMessage => string.Format(ErrorMessages.MaxLengthRule, maxLength);

        public override bool IsValid(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            return value.Length <= maxLength;
        }
    }
}
