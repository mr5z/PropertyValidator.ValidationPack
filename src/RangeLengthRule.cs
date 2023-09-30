using PropertyValidator.Models;

namespace PropertyValidator.ValidationPack
{
    public class RangeLengthRule : ValidationRule<string?>
    {
        private int minLength;
        private int maxLength;

        public override string ErrorMessage => string.Format(ErrorMessages.RangeLengthRule, minLength, maxLength);

        public RangeLengthRule(int minLength, int maxLength)
        {
            this.minLength = minLength;
            this.maxLength = maxLength;
        }

        public override bool IsValid(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            if (value.Length <= minLength) return false;
            if (value.Length >= maxLength) return false;
            return true;
        }
    }
}
