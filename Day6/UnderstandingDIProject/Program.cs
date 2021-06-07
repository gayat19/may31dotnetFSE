using System;

namespace UnderstandingDIProject
{
    /// <summary>
    /// Acts as teh provider
    /// </summary>
    class Program
    {
        IRepo repo;
        Clinic clinic;
        Program()
        {
            repo = new PatientRepo();
            clinic = new Clinic(repo);
        }
        void DoClinicWork()
        {
            clinic.AddPatient();
            clinic.PrintPatients();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().DoClinicWork();
            Console.ReadKey();
        }
    }
}
