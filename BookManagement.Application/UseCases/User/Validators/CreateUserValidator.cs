using BookManagement.Application.UseCases.User.Commands;
using FluentValidation;

namespace BookManagement.Application.UseCases.User.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(u => u.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MinimumLength(3).WithMessage("Name must be at least 3 characters long.")
            .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

        RuleFor(u => u.Email)
            .NotEmpty().WithMessage("Email is required.")
            .MinimumLength(3).WithMessage("Email must be at least 3 characters long.")
            .MaximumLength(100).WithMessage("Email cannot exceed 100 characters.")
            .EmailAddress().WithMessage("Email is invalid.");

        RuleFor(u => u.Password)
            .NotEmpty().WithMessage("Password is required.")
            .Length(8, 150).WithMessage("Password must be at least 8 characters long and cannot exceed 150 characters. ");

    }
}