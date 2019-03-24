using System;
using System.Collections.Generic;
using System.Text;

namespace BaseOOP
{
    public class Manager:Employee
    {
        public List<Employee> Team { get; private set; }

        public Manager(string firstName, string secondName, float salary, int experience)
            : base(firstName, secondName, salary, experience, null)
        {
            Team = new List<Employee>();
        }

        public override float GetSalary()
        {
            float tempSalary = CheckMembers();
            if (GetDevelopers() > Team.Count/2)
                tempSalary += Salary * 0.1f;
            
            return tempSalary;
        }

        private int GetDevelopers()
        {
            int countDev = 0;
            foreach(var t in Team)
            {
                if (t is Developer)
                    countDev++;
            }
            return countDev;
        }

        private float CheckMembers()
        {
            float tempSalary = GetBonus();
            if (Team.Count > 5 && Team.Count <= 10)
                tempSalary = GetBonus() + 200;
            else if (Team.Count > 10)
                tempSalary = GetBonus() + 300;
                
            return tempSalary;
        }
    }
}
