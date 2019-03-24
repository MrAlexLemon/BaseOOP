using System;

namespace BaseOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dp = new Department();
            try
            {
                Manager mn = new Manager("Ivan", "Ivanov", 22.1f, 5);
                dp.Teams.Add(mn);
                dp.Teams[0].Team.Add(new Developer("Vasul", "Vasulenko", 12.5f, 1, mn));
                Console.WriteLine(dp.Teams[0].Team[0].ToString());
                Console.WriteLine(dp.Teams[0].Team[0].Manager.ToString());
                Console.WriteLine(dp.Teams[0].ToString());
                Console.WriteLine("Managers salary: "+dp.Teams[0].Team[0].Manager.GetSalary());
                dp.GiveSalary();
                Console.WriteLine("First member of team got salary: "+dp.Teams[0].Team[0].GetSalary());
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
