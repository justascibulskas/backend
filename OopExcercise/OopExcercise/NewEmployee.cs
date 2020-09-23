using System;
using System.Collections.Generic;
using System.Text;

namespace OopExcercise
{
    public class NewEmployee
    {
        public NewEmployee(int salary, int sickTime, string medicalPlan)
        {
            this.Salary = salary;
            this.SickTime = sickTime;
            this.MedicalPlan = medicalPlan;
        }

        public int Salary { get; set; }
        public int SickTime { get; set; }
        public string MedicalPlan { get; set; }


        public void taxes ()
        {
            Console.WriteLine("taxes");
        }

    public virtual void benefits()
        {
            Console.WriteLine("benefits");
        }



    }
}
