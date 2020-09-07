using Blazored.Modal.Services;
using Hsf.ApplicatonProcess.August2020.Blazor.services;
using Hsf.ApplicatonProcess.August2020.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
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
        [CascadingParameter]
        public IModalService Modal { get; set; }

        protected Applicant applicant = new Applicant();

        protected EditContext editContext;

        protected bool IsApplicantAcceptModalDisabled { get; set; } = true;
        protected bool IsResetAcceptModalDisabled { get; set; } = true;

        public IEnumerable<Applicant> Applicants { get; set; }

        protected override void OnInitialized()
        {
            this.editContext = new EditContext(this.applicant);
            this.editContext.OnFieldChanged += (sender, e) =>
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

                if (string.IsNullOrEmpty(applicant.Name) ||
                    string.IsNullOrEmpty(applicant.FamilyName) ||
                    string.IsNullOrEmpty(applicant.Address) ||
                    string.IsNullOrEmpty(applicant.CountryOfOrigin) ||
                    string.IsNullOrEmpty(applicant.EMailAdress))
                {
                    this.IsApplicantAcceptModalDisabled = true;
                }
                else
                {
                    this.IsApplicantAcceptModalDisabled = false;
                }

                this.StateHasChanged();
            };
        }

        protected async Task SaveApplicant()
        {
            await ApplicantService.AddApplicant(applicant);
            Modal.Show<ApplicantAcceptModal>("Applicant added");
        }

        protected async Task ShowResetAcceptModal()
        {
            var modal = Modal.Show<ResetAcceptModal>("Are You sure?");
            var modalResult = await modal.Result;

            if (!modalResult.Cancelled)
            {
                @applicant.Name = "";
                @applicant.FamilyName = "";
                @applicant.Address = "";
                @applicant.CountryOfOrigin = "";
                @applicant.EMailAdress = "";
                @applicant.Age = 0;
                @applicant.Hired = false;
            }
        }
    }
}
