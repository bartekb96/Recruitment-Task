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
        public IEnumerable<Applicant> Applicants { get; set; }

        private void LoadApplicants()
        {
            Applicant a1 = new Applicant
            {
                ID = 1,
                Name = "Bartosz",
                FamilyName = "Bednarek",
                Address = "Kalinowa 26",
                CountryOfOrigin = "Poland",
                EMailAdress = "bartekbednarek@gmail.com",
                Age = 24,
                Hired = false
            };

            Applicant a2 = new Applicant
            {
                ID = 2,
                Name = "Mariusz",
                FamilyName = "Pudzianowski",
                Address = "Kwiatowa 22",
                CountryOfOrigin = "Poland",
                EMailAdress = "mariuszpudzianowski@gmail.com",
                Age = 40,
                Hired = true
            };

            Applicant a3 = new Applicant
            {
                ID = 3,
                Name = "Adam",
                FamilyName = "Malysz",
                Address = "Wielka Krokwia 35",
                CountryOfOrigin = "Poland",
                EMailAdress = "adammalysz@gmail.com",
                Age = 39,
                Hired = true
            };

            Applicants = new List<Applicant> { a1, a2, a3 };
        }
    }
}
