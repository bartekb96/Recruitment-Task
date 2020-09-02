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

        public bool IsSubmitDialogVisible { get; set; } = false;
        public bool IsResetDialogVisible { get; set; } = false;

        public IEnumerable<Applicant> Applicants { get; set; }

        protected async Task SaveApplicant()
        {
            await ApplicantService.AddApplicant(applicant);
            Modal.Show<ApplicantAcceptModal>("Applicant added");
        }

        protected async Task ShowResetAcceptModal()
        {

        }

    }

}
