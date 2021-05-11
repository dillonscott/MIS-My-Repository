using System;
using System.Collections.Generic;
using System.IO;

namespace HW8_ClassesExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] patientsInfo = File.ReadAllLines("AppointmentInformation.csv");
            List<Patient> patients = new List<Patient>();

            for (int i = 1; i < patientsInfo.Length; i++)
            {
                string patientInfo = patientsInfo[i];
                string[] pieces = patientInfo.Split(',');
                //AppointmentDate,FirstName,MiddleInitial,LastName,ID,FluVaccine,Weight,AddMedications
                //      0             1          2           3      4      5       6         7

                Patient p = new Patient();
                p.FirstName = pieces[1];
                p.MidInitial = Convert.ToChar(pieces[2]);
                p.LastName = pieces[3];
                p.ID = Convert.ToInt32(pieces[4]);
                if (pieces[5] == "Y")
                {
                    p.FluVaccineYN = true;
                }
                else
                {
                    p.FluVaccineYN = false;
                }
                p.Weights.Add(Convert.ToDateTime(pieces[0]), Convert.ToDouble(pieces[6]));
                p.Perscriptions.Add(pieces[7]);

                patients.Add(p);
                
            }

            foreach (Patient pat in patients)
            {
                Console.WriteLine($"\n{ pat}");
                pat.PerscribeMedicine("That good good (Tramadol)");
                pat.DisplayMedicine();
                double maxWeight = pat.CalculateMaxWeight();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{pat.FirstName} {pat.LastName} had a max weight of {maxWeight} pounds");
                Console.ResetColor();
                pat.AdministerVaccine();

                

                    

                
            }

            

            





        }
    }
}
