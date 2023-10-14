[![NuGet Version](https://img.shields.io/nuget/v/PropertyValidator.ValidationPack.svg)](https://www.nuget.org/packages/PropertyValidator.ValidationPack/)
[![NuGet Pre-release](https://img.shields.io/nuget/vpre/PropertyValidator.ValidationPack.svg)](https://www.nuget.org/packages/PropertyValidator.ValidationPack/)
[![GitHub Release](https://img.shields.io/github/release/mr5z/PropertyValidator.ValidationPack.svg?style=flat)](https://github.com/mr5z/PropertyValidator.ValidationPack/packages/385702)
[![NuGet Downloads](https://img.shields.io/nuget/dt/PropertyValidator.ValidationPack.svg)](https://www.nuget.org/packages/PropertyValidator.ValidationPack/)

## Installation

You can install the ValidationPack library via NuGet:

```shell
Install-Package PropertyValidator.ValidationPack
```

## Contains validation rules for [PropertyValidator](https://github.com/mr5z/PropertyValidator)
This ValidationPack contains a set of common validation rules to cover popular input validation scenarios. The ValidationPack includes the following rules:
- StringRequiredRule: Ensures that a string property is not empty or null.
- MaxLengthRule: Validates that a string does not exceed a specified maximum length.
- MinLengthRule: Checks that a string meets a specified minimum length.
- RangeLengthRule: Validates that a string falls within a specific length range.
- EmailFormatRule: Ensures that a string follows a valid email format.

### Customizable Error Messages
The error messages for these validation rules are provided through the ErrorMessages.resx file in the ValidationPack. However, you can easily customize these error messages to suit your application's needs.

To replace the default error messages with your custom messages, follow these steps:
1. Create your own .resx file with custom error messages.
2. Use the ErrorMessageHelper.UpdateResource<T>() method, where T is the name of your custom .resx file. For example:
```csharp
using PropertyValidator.ValidationPack;

// Replace "YourCustomErrorMessages" with the name of your custom .resx file
ErrorMessageHelper.UpdateResource<YourCustomErrorMessages>();
```
3. Override the following keys:

   ![image](https://github.com/mr5z/PropertyValidator/assets/6318395/8fc0f0c8-02eb-460e-9acc-f63eb4de7653)
