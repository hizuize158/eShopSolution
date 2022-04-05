using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Firstname is required")
                .MinimumLength(200).WithMessage("Firstname can't over 200 characters");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Lastname is requited")
                .MinimumLength(200).WithMessage("Lastname can't over 200 characters");
            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday can't greater than 100 years");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is requited")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber is required");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");
            RuleFor(x => x).Custom((request, context) => {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
        }
    }
}
