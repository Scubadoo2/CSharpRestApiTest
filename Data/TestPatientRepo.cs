using System.Collections.Generic;
using HealthDatabase.Models;

namespace HealthDatabase.Data{

    public class TestPatientRepo : IHealthDatabaseRepo
    {

        private TestPatientDataHolder patients = new TestPatientDataHolder();

        public IEnumerable<Patient> GetAllPatients()
        {
            return patients.GetAllPatients();
        }

        public Patient GetPatientByFirstName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Patient GetPatientByLastName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Patient GetPatientByName(string firstName, string lastName)
        {
            throw new System.NotImplementedException();
        }
    }

}