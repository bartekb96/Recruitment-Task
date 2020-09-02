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

        protected Applicant applicant = new Applicant();

        public IEnumerable<Applicant> Applicants { get; set; }

        protected async Task SaveApplicant()
        {
            await ApplicantService.AddApplicant(applicant);
        }
    }

}
