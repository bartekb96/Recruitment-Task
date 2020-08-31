using FluentValidation;
using Hsf.ApplicatonProcess.August2020.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Blazor.Pages
{
    public class ApplicantValidator : AbstractValidator<Applicant>
    {
        public ApplicantValidator()
        {
            RuleFor(applicant => applicant.Name).NotEmpty().WithMessage("You must enter Your name");
            RuleFor(applicant => applicant.Name).MinimumLength(5).WithMessage("Entered name is invalid, to short name");

            RuleFor(applicant => applicant.FamilyName).NotEmpty().WithMessage("You must enter Your family name");
            RuleFor(applicant => applicant.FamilyName).MinimumLength(5).WithMessage("Entered family name is invalid, to short family name");

            RuleFor(applicant => applicant.Address).NotEmpty().WithMessage("You must enter Your address");
            RuleFor(applicant => applicant.Address).MinimumLength(10).WithMessage("Entered address name is invalid, to short address");

            RuleFor(applicant => applicant.Age).GreaterThanOrEqualTo(20).WithMessage("You must be at least 20 years old");
            RuleFor(applicant => applicant.Age).LessThanOrEqualTo(60).WithMessage("You must be maximum 60 years old");

            RuleFor(applicant => applicant.Hired).NotNull().WithMessage("Please select Your hired status");
        }
    }
}