using Hsf.ApplicatonProcess.August2020.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Data.Models
{
    public interface IApplicantRepository
    {
        Task<IEnumerable<Applicant>> GetApplicants();
        Task<Applicant> GetApplicant(int applicantId);
        Task<Applicant> AddApplicant(Applicant applicant);
        Task<Applicant> UpdateApplicant(Applicant applicant);
        Task<Applicant> DeleteApplicant(int applicantId);
    }
}
