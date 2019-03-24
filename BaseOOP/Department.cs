using System;
using System.Collections.Generic;
using System.Text;

namespace BaseOOP
{
    
    public class Department
    {
        public List<Manager> Teams { get; private set; }

        public Department()
        {
            Teams = new List<Manager>();
        }

        public void GiveSalary()
        {
            foreach(var t in Teams)
            {
                for (int i=0;i<t.Team.Count;i++)
                    Console.WriteLine($"{t.Team[i].FirstName} {t.Team[i].SecondName}: got salary: {t.Team[i].GetSalary()}");
            }
        }
    }
}
