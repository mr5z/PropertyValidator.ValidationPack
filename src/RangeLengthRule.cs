using PropertyValidator.Models;

namespace PropertyValidator.ValidationPack;

public class RangeLengthRule(int minLength, int maxLength) : ValidationRule<string?>
{
    public override string ErrorMessage => string.Format(ErrorMessages.RangeLengthRule, minLength, maxLength);

    public override bool IsValid(string? value)
    {
        if (string.IsNullOrEmpty(value)) return false;
        if (value.Length < minLength) return false;
        if (value.Length > maxLength) return false;
        
        return true;
    }
}
