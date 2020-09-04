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

        /// <summary>
        /// Gets the list of all Applicants
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET api/Applicants
        /// </remarks>
        /// <returns>The list of Applicants</returns>
        // GET: api/Applicants
        /// <response code="200">Returns list of all Applicants</response>
        /// <response code="500">If here was problem with server</response>   
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
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

        /// <summary>
        /// Gets an Applicant with specify ID
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET api/Applicants/1
        /// </remarks>
        /// <returns>The specify Applicants</returns>
        /// <response code="200">Returns the specify Applicant</response>
        /// <response code="404">If there is no Applicant with this ID in database</response>     
        /// <response code="500">If here was problem with server</response>   
        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
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

        /// <summary>
        /// Creates a new Applicant
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Applicants
        ///     {        
        ///               "name": "Bartosz",
        ///               "familyName": "Bednarek",
        ///               "address": "Kalinowa 26",
        ///               "countryOfOrigin": "Poland",
        ///               "eMailAdress": "bb@gmail.com",
        ///               "age": 22,
        ///               "hired": false       
        ///     }
        /// </remarks>
        /// <param name="applicant"></param> 
        /// <response code="201">Returns the newly created Applicant</response>
        /// <response code="400">If the posted Applicant is null</response>     
        /// <response code="500">If here was problem with server</response>    
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
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

        /// <summary>
        /// Updates an Applicant
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT api/Applicants/1
        ///     {        
        ///               "ID": 1,
        ///               "name": "Bartosz",
        ///               "familyName": "Bednarek",
        ///               "address": "Kalinowa 26",
        ///               "countryOfOrigin": "Poland",
        ///               "eMailAdress": "bb@gmail.com",
        ///               "age": 22,
        ///               "hired": false       
        ///     }
        /// </remarks>
        /// <param name="applicant"></param> 
        /// <response code="200">Returns the newly updated Applicant</response>
        /// <response code="400">If puted ID is different than ID of puted Applicant</response>  
        /// <response code="404">If there is no Applicant with this ID in database</response>     
        /// <response code="500">If here was problem with server</response>    
        [HttpPut("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
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

        /// <summary>
        /// Delete an Applicant
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     DELETE api/Applicants/1
        /// </remarks>
        /// <response code="200">Returns the newly deleted Applicant</response>
        /// <response code="404">If there is no Applicant with this ID in database</response>     
        /// <response code="500">If here was problem with server</response>   
        [HttpDelete("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
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
