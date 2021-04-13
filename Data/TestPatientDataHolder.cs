using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using HealthDatabase.Models;

namespace HealthDatabase.Data{

    public class TestPatientDataHolder{

        public IList<Patient> data;

        public TestPatientDataHolder(){
            string dataString = File.ReadAllText("TestData.json");
            data = JsonSerializer.Deserialize<IList<Patient>>(dataString);

        }

        public IList<Patient> GetAllPatients(){
            return data;
        }

    }

}