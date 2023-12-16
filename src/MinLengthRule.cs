﻿using PropertyValidator.Models;

namespace PropertyValidator.ValidationPack;

public class MinLengthRule(int minLength) : ValidationRule<string?>
{
    private readonly int minLength = minLength;

    public override string ErrorMessage => string.Format(ErrorMessages.MinLengthRule, minLength);

    public override bool IsValid(string? value)
    {
        if (string.IsNullOrEmpty(value))
            return true;

        return value.Length >= minLength;
    }
}
