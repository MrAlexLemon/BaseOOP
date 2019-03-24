using System;
using System.Collections.Generic;
using System.Text;

namespace BaseOOP
{
    public class Developer : Employee
    {

        public Developer(string firstName, string secondName, float salary, int experience, Manager manager)
            :base(firstName,secondName,salary,experience,manager)
        {
            
        }


        public override float GetSalary()
        {
            return GetBonus();
        }
    }
}
