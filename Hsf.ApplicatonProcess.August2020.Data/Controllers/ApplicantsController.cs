using Hsf.ApplicatonProcess.August2020.Data.Models;
using Hsf.ApplicatonProcess.August2020.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hsf.ApplicatonProcess.August2020.Data.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly IApplicantRepository applicantRepository;

        public ApplicantsController(IApplicantRepository applicantRepository)
        {
            this.applicantRepository = applicantRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetApplicants()
        {
            try
            {
                return Ok(await applicantRepository.GetApplicants());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Accessing database error!");
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Applicant>> GetApplicant(int id)
        {
            try
            {
                var result = await applicantRepository.GetApplicant(id);

                if(result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Accessing database error!");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Applicant>> CreateApplicant(Applicant applicant)
        {
            try
            {
                if(applicant == null)
                {
                    return BadRequest();
                }

                var createdApplicant = await applicantRepository.AddApplicant(applicant);
                return CreatedAtAction(nameof(GetApplicant), new { id = createdApplicant.ID }, createdApplicant);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Accessing database error!");
            }
        }

    }

}
