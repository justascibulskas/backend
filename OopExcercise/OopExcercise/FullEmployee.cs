using System;
using System.Collections.Generic;
using System.Text;

namespace OopExcercise
{
    public class FullEmployee : NewEmployee
    {
        public int DentalPlan { get; set; }
        public int Vacation { get; set; }
        public int Car { get; set; }

        public FullEmployee(int salary, int sickTime, string medicalPlan, int dentalPlan, int vacation, int car):base(salary,sickTime,medicalPlan)
        {
            this.DentalPlan = dentalPlan;
            this.Vacation = vacation;
            this.Car = car;
        }

        public override void benefits()
        {
            base.benefits();
        }

    }
}
