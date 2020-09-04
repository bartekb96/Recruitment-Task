using Blazored.Modal.Services;
using Hsf.ApplicatonProcess.August2020.Blazor.services;
using Hsf.ApplicatonProcess.August2020.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Blazor.Pages
{
    public class ApplicantRejestrationBase : ComponentBase
    {
        [Inject]
        public IApplicantService ApplicantService { get; set; }

        [Inject]
        public IModalService Modal { get; set; }

        protected Applicant applicant = new Applicant();

        protected bool IsApplicantAcceptModalActive { get; set; } = false;
        protected bool IsResetAcceptModalDisabled { get; set; } = true;

        public string Name { get; set; } = "";

        public IEnumerable<Applicant> Applicants { get; set; }

        protected async Task SaveApplicant()
        {
            await ApplicantService.AddApplicant(applicant);
            Modal.Show<ApplicantAcceptModal>("Applicant added");
        }

        protected void ShowResetAcceptModal()
        {
            Modal.Show<ResetAcceptModal>("Are You sure?");
        }

        public void CheckFormState()
        {
            if (string.IsNullOrEmpty(applicant.Name) &&
               string.IsNullOrEmpty(applicant.FamilyName) &&
               string.IsNullOrEmpty(applicant.Address) &&
               string.IsNullOrEmpty(applicant.CountryOfOrigin) &&
               string.IsNullOrEmpty(applicant.EMailAdress))
            {
                this.IsResetAcceptModalDisabled = true;
            }
            else
            {
                this.IsResetAcceptModalDisabled = false;
            }
        }

        public void test()
        {
            this.IsResetAcceptModalDisabled = !this.IsResetAcceptModalDisabled;
        }
    }

}
