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

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Applicant>> UpdateApplicant(int ID, Applicant applicant)
        {
            try
            {
                if(ID != applicant.ID)
                {
                    return BadRequest("Wrong applicant ID");
                }

                var applicantToUpdate = await applicantRepository.GetApplicant(ID);

                if (applicantToUpdate == null)
                {
                    return NotFound($"Applicant with id = {ID} not found");
                }

                return await applicantRepository.UpdateApplicant(applicant);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Updating applicant error!");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Applicant>> DeleteApplicant(int ID)
        {
            try
            {
                var applicantToDelete = await applicantRepository.GetApplicant(ID);

                if (applicantToDelete == null)
                {
                    return NotFound($"Applicant with id = {ID} not found");
                }

                return await applicantRepository.DeleteApplicant(ID);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Deleting applicant error!");
            }
        }
    }

}
