using System.Collections.Generic;

namespace HealthDatabase.Models{

    public class Patient{
        public int id {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public int age {get; set;}
        public string street {get; set;}
        public string city {get; set;}
        public string state {get; set; }
        public IList<string> interests {get; set;}
    }

}
