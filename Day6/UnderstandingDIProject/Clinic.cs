using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDIProject
{
    class Clinic 
    {
        private readonly IRepo _repo;

        public Clinic()
        {

        }
        public Clinic(IRepo repo)
        {
            _repo = repo;
        }
        public void PrintPatients()
        {
            List<Patient> patients = _repo.GetAll().ToList();
            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
            }
        }
        public void AddPatient()
        {
            string choice = "no";
            do
            {
                Patient patient = new Patient();
                patient.TakePatientDetailsFromUser();
                _repo.Add(patient);
                Console.WriteLine("Do you like to continue?? Id not then enter no");
                choice = Console.ReadLine().ToLower();
            } while (choice != "no");
        }
    }
}
