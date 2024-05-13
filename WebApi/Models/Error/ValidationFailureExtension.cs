using FluentValidation.Results;

namespace WebApi.Models.Error;

public static class ValidationFailureExtension
{
    public static IList<CustomValidatorFailure> ToCustomValidationFailure(this IList<ValidationFailure> failures)
    {
        return failures.Select(f => new CustomValidatorFailure(f.PropertyName, f.ErrorMessage)).ToList();
    }
}