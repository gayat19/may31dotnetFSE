using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDIProject
{
    class PatientRepo :IRepo//Implements the Repo interface

    {
        //Patient[] patients;
        List<Patient> patients;
        public PatientRepo()
        {
            //patients = new Patient[10];
            patients = new List<Patient>();
        }
        public void Add(Patient patien)
        {
            patients.Add(patien);
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Patient Get(int Id)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].Id == Id)
                {
                    return patients[i];
                }
            }
            return null;
        }

        public IList<Patient> GetAll()
        {
            return patients;
        }
    }
}
