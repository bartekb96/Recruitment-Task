using FluentValidation;
using Hsf.ApplicatonProcess.August2020.Blazor.services;
using Hsf.ApplicatonProcess.August2020.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Blazor.Pages
{
    public class ApplicantValidator : AbstractValidator<Applicant>
    {
        public ApplicantValidator()
        {
            //Name tules
            RuleFor(applicant => applicant.Name).NotEmpty().WithMessage("You must enter Your name");
            RuleFor(applicant => applicant.Name).MinimumLength(5).WithMessage("Entered name is invalid, to short name");

            //Family anme rules
            RuleFor(applicant => applicant.FamilyName).NotEmpty().WithMessage("You must enter Your family name");
            RuleFor(applicant => applicant.FamilyName).MinimumLength(5).WithMessage("Entered family name is invalid, to short family name");

            //Address rules
            RuleFor(applicant => applicant.Address).NotEmpty().WithMessage("You must enter Your address");
            RuleFor(applicant => applicant.Address).MinimumLength(10).WithMessage("Entered address name is invalid, to short address");

            //Country rules
            RuleFor(applicant => applicant.CountryOfOrigin).Must(IsRealCountry).WithMessage("This country does not exist");

            //Email rules
            RuleFor(applicant => applicant.EMailAdress).NotEmpty().WithMessage("You must enter Your E-mail address");
            RuleFor(applicant => applicant.EMailAdress).Matches(@"^\w+@\w+\.\w+$").WithMessage("Your email is not valid");

            //Age rules
            RuleFor(applicant => applicant.Age).GreaterThanOrEqualTo(20).WithMessage("You must be at least 20 years old");
            RuleFor(applicant => applicant.Age).LessThanOrEqualTo(60).WithMessage("You must be maximum 60 years old");

            //Hired status rules
            RuleFor(applicant => applicant.Hired).NotNull().WithMessage("Please select Your hired status");
        }

        private bool IsRealCountry(Applicant applicant, string CountryOfOrigin)
        {
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("https://restcountries.eu/rest/v2/name/" + CountryOfOrigin);
            httpReq.AllowAutoRedirect = false;

            try
            {
                HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();

                if (httpRes.StatusCode == HttpStatusCode.OK)
                {
                    httpRes.Close();
                    return true;
                }

                httpRes.Close();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

    }
}