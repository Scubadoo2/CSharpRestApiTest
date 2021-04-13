using System.Collections.Generic;
using HealthDatabase.Data;
using HealthDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthDatabase.Controller{

    [Route("api/patients")]
    [ApiController]
    public class PatientsController : ControllerBase{

        private readonly IHealthDatabaseRepo repository;

        public PatientsController(IHealthDatabaseRepo newRepo){
            repository = newRepo;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Patient>> GetAllPatients(){
            var patientList = repository.GetAllPatients();
            return Ok(patientList);
        }

    }

}