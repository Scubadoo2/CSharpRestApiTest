using System.Collections.Generic;
using HealthDatabase.Models;

namespace HealthDatabase.Data{

    public interface IHealthDatabaseRepo{

        IEnumerable<Patient> GetAllPatients();
        Patient GetPatientByFirstName(string name);
        Patient GetPatientByLastName(string name);
        Patient GetPatientByName(string firstName, string lastName);
        
    }

}