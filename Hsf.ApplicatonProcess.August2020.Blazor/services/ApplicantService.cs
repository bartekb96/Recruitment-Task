using Hsf.ApplicatonProcess.August2020.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Blazor.services
{
    public class ApplicantService : IApplicantService
    {
        private readonly HttpClient httpClient;

        public ApplicantService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Applicant> AddApplicant(Applicant applicant)
        {
            return await httpClient.PostJsonAsync<Applicant>("api/applicants", applicant);
        }
    }
}
