using Hsf.ApplicatonProcess.August2020.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Data.Models
{
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly AppDbContext appDbContext;

        public ApplicantRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Applicant>> GetApplicants()
        {
            return await appDbContext.Applicants.ToListAsync();
        }

        public async Task<Applicant> GetApplicant(int applicantId)
        {
            return await appDbContext.Applicants.FirstOrDefaultAsync(a => a.ID == applicantId);
        }

        public async Task<Applicant> AddApplicant(Applicant applicant)
        {
            var result = await appDbContext.Applicants.AddAsync(applicant);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
            
        }

        public async Task<Applicant> UpdateApplicant(Applicant applicant)
        {
            var result = await appDbContext.Applicants.FirstOrDefaultAsync(a => a.ID == applicant.ID);
            if(result != null)
            {
                result.Name = applicant.Name;
                result.FamilyName = applicant.FamilyName;
                result.Address = applicant.Address;
                result.CountryOfOrigin = applicant.CountryOfOrigin;
                result.EMailAdress = applicant.EMailAdress;
                result.Age = applicant.Age;
                result.Hired = applicant.Hired;

                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async void DeleteApplicant(int applicantId)
        {
            var result = await appDbContext.Applicants.FirstOrDefaultAsync(a => a.ID == applicantId);
            if(result != null)
            {
                appDbContext.Applicants.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }
    }
}
