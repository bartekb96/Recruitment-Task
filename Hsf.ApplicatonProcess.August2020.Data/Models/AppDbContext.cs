using Hsf.ApplicatonProcess.August2020.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Applicant> Applicants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Applicant>().HasData(new Applicant
            {
                ID = 1,
                Name = "Bartosz",
                FamilyName = "Bednarek",
                Address = "Kalinowa 26",
                CountryOfOrigin = "Poland",
                EMailAdress = "bartekbednarek@gmail.com",
                Age = 24,
                Hired = false
            });

            modelBuilder.Entity<Applicant>().HasData(new Applicant
            {
                ID = 2,
                Name = "Mariusz",
                FamilyName = "Pudzianowski",
                Address = "Kwiatowa 22",
                CountryOfOrigin = "Poland",
                EMailAdress = "mariuszpudzianowski@gmail.com",
                Age = 40,
                Hired = true
            });

            modelBuilder.Entity<Applicant>().HasData(new Applicant
            {
                ID = 3,
                Name = "Adam",
                FamilyName = "Malysz",
                Address = "Wielka Krokwia 35",
                CountryOfOrigin = "Poland",
                EMailAdress = "adammalysz@gmail.com",
                Age = 39,
                Hired = true
            });
        }
    }
}
