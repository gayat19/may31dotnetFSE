using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTUDUnderstandingProject
{
    public class Clinic
    {
        Patient[] patients;
        public Clinic()
        {
            Console.WriteLine("Please enter the maximum count of patients");
            int size;
            while (!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid entry for size. Try again...");
            }
            patients = new Patient[size];
        }
        /// <summary>
        /// Will take all the patients details. The number of patients is already given.
        /// </summary>
        public void AddPatients()
        {
            for (int i = 0; i < patients.Length; i++)
            {
                patients[i] = new Patient();
                patients[i].TakePatientDetailsFromUser();
            }
        }
        /// <summary>
        /// Prints a single patient details
        /// </summary>
        /// <param name="patient">The paient object</param>
        public void PrintPatientDetails(Patient patient)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(patient);
            Console.WriteLine("--------------------");
        }
        /// <summary>
        /// Print all the patient details
        /// </summary>
        public void PrintAllPatientDetails()
        {
            foreach (Patient patient in patients)
            {
                PrintPatientDetails(patient);
            }
        }
        /// <summary>
        /// Finds a patient using the id of the patient
        /// </summary>
        /// <param name="id">Patient Id</param>
        /// <returns></returns>
        int FindPatientUsingId(int id)
        {
            int index = -1;
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i].Id == id)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        int GetPatientId()
        {
            Console.WriteLine("Please enter the patient ID");
            int id;
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry for Id. Try again...");
            }
            return id;
        }
        /// <summary>
        /// Prints the patient details by taking the Id from user. if the Id does not exist then print teh message and or
        /// Prints the Patient details
        /// </summary>
        public void PrintPatientById()
        {
            Console.WriteLine("Print the patient details by ID");
            int id = GetPatientId();
            int idx = FindPatientUsingId(id);
            if(idx ==-1)
            {
                Console.WriteLine($"No patient with the id {id}");
                return;//will return the control back to teh calling line
            }
            PrintPatientDetails(patients[idx]);
        }
        public void EditPatientDetailsById()
        {
            Console.WriteLine("Edit patient details by ID");
            int id = GetPatientId();
            int idx = FindPatientUsingId(id);
            if (idx == -1)
            {
                Console.WriteLine($"No patient with the id {id}");
                return;//will return the control back to teh calling line
            }
            Console.WriteLine("The patient details in record  ");
            PrintPatientDetails(patients[idx]);
            string choice;
            Console.WriteLine("Do you want to add more to the patients medical condition??");
            choice = Console.ReadLine().ToLower();
            if(choice == "yes")
            {
                Console.WriteLine("Please enter the details you wish to add to medical condition");
                string data = Console.ReadLine();
                patients[idx].Remarks += data;
                Console.WriteLine("Condition updated");
                PrintPatientDetails(patients[idx]);
                return;
            }
            Console.WriteLine("Do you want to add more to the patients phone?");
            choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                Console.WriteLine("Please enter new phone number");
                patients[idx].Phone = Console.ReadLine();
                Console.WriteLine("Phone number updated");
                PrintPatientDetails(patients[idx]);
                return;
            }
            Console.WriteLine("No updations were made......");
        }
        public void PrintChoiceForUser()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Please enter you choice");
                Console.WriteLine("1. Print all the patient details");
                Console.WriteLine("2. Print any patient detail");
                Console.WriteLine("3. Edit patient details");
                Console.WriteLine("0. Exit the application");
                while (!Int32.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid entry. Try again...");
                }
                switch (choice)
                {
                    case 1:
                        PrintAllPatientDetails();
                        break;
                    case 2:
                        PrintPatientById();
                        break;
                    case 3:
                        EditPatientDetailsById();
                        break;
                    case 0:
                        Console.WriteLine("Bye bye.....");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice!=0);
        }
    }
}
