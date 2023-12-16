using PropertyValidator.Models;

namespace PropertyValidator.ValidationPack;

public class MaxLengthRule(int maxLength) : ValidationRule<string?>
{
    private readonly int maxLength = maxLength;

    public override string ErrorMessage => string.Format(ErrorMessages.MaxLengthRule, maxLength);

    public override bool IsValid(string? value)
    {
        if (string.IsNullOrEmpty(value))
            return true;

        return value.Length <= maxLength;
    }
}
