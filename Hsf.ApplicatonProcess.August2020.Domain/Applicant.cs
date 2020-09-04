using System;
using System.ComponentModel.DataAnnotations;

namespace Hsf.ApplicatonProcess.August2020.Domain
{
    public class Applicant
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FamilyName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string CountryOfOrigin { get; set; }
        [Required]
        public string EMailAdress { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public bool Hired { get; set; }
    }
}
