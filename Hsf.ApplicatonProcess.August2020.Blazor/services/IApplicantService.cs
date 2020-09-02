using Hsf.ApplicatonProcess.August2020.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Blazor.services
{
    public interface IApplicantService
    {
        public Task<Applicant> AddApplicant(Applicant applicant);
    }
}
