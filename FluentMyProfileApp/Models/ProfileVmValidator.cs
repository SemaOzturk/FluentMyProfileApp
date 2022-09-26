using FluentValidation;

namespace FluentMyProfileApp.Models;

public class ProfileVmValidator :AbstractValidator<ProfileVm>
{
    public ProfileVmValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required");
        RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email is required");
        RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Email is not valid");
        RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone is required");
        RuleFor(x => x.PhoneNumber).Matches(@"^\d{3}-\d{3}-\d{4}$").WithMessage("Phone is not valid");
        RuleFor(x=>x.DateOfBirth).InclusiveBetween(new DateTime(1971,1,1),new DateTime(2012,1,1)).WithMessage("Date of birth is not valid");
    }
}