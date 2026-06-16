using BookManagement.Application.UseCases.User.Commands;
using FluentValidation;
using FluentValidation.Validators;

namespace BookManagement.Application.UseCases.User.Validators;

public class UpdateNameValidator : AbstractValidator<UpdateName.UpdateNameCommand>
{
    public UpdateNameValidator()
    {
        RuleFor(u => u.NewName)
            .NotEmpty().WithMessage("Name is required.")
            .MinimumLength(3).WithMessage("Name must be at least 3 characters long.")
            .MaximumLength(150).WithMessage("Name cannot exceed 150 characters.");
    }
}