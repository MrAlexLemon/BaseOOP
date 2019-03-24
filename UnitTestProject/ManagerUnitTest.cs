using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseOOP;
using System;


namespace UnitTestProject
{
    [TestClass]
    public class ManagerUnitTest
    {
        [TestMethod]
        public void ManagerTestSalaryLowExperienceLowMembers()
        {
            float salary = 1000;
            int experience = 1;
            float effective = 0.123f;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for(int i=0; i<4;i++)
                man.Team.Add(new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalaryLowExperienceBigTeam()
        {
            float salary = 1000;
            int experience = 1;
            float effective = 0.123f;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 12; i++)
                man.Team.Add(new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = salary+300;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalaryBigExperienceBigTeam()
        {
            float salary = 1000;
            int experience = 10;
            float effective = 0.123f;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 12; i++)
                man.Team.Add(new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = 300+salary*1.2f+500;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalaryBigExperienceLowTeam()
        {
            float salary = 1000;
            int experience = 10;
            float effective = 0.123f;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 6; i++)
                man.Team.Add(new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = 200 + salary * 1.2f + 500;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalaryBigExperienceSmallTeamDeveloper()
        {
            float salary = 1000;
            int experience = 10;
            float effective = 0.123f;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 3; i++)
                man.Team.Add(new Developer("DesFirstName", "DesSecondName", salary, experience,
               new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = salary * 1.2f + 500 + 0.1f*salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalaryBigExperienceBigTeamDevelopers()
        {
            float salary = 1000;
            int experience = 10;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 12; i++)
                man.Team.Add(new Developer("DesFirstName", "DesSecondName", salary, experience,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = 300 + salary * 1.2f + 500 + 0.1f*salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalaryMidExperienceBigTeamDevelopers()
        {
            float salary = 1000;
            int experience = 4;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 12; i++)
                man.Team.Add(new Developer("DesFirstName", "DesSecondName", salary, experience,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = 300 + salary + 200 + 0.1f * salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalaryMidExperienceSmallTeamDevelopers()
        {
            float salary = 1000;
            int experience = 4;
            float efeccitve = 0.5f;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 4; i++)
                man.Team.Add(new Designer("DesFirstName", "DesSecondName", salary, experience, efeccitve,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = salary + 200;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalarySmallExperienceBigTeamDevelopers()
        {
            float salary = 1000;
            int experience = 1;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 12; i++)
                man.Team.Add(new Developer("DesFirstName", "DesSecondName", salary, experience,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = 300 +  0.1f * salary + salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestSalarySmallExperienceSmallTeam()
        {
            float salary = 1000;
            int experience = 1;
            float effective = 0.123f;
            Manager man = new Manager("DesFirstName", "DesSecondName", salary, experience);
            for (int i = 0; i < 2; i++)
                man.Team.Add(new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5)));

            float realSalary = man.GetSalary();
            float expectedSalary = salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Salary is wrong number.")]
        public void DeveloperWrongExperience()
        {
            float salary = -12;
            int experience = 12;
            Manager man = new Manager("ManagerFirstName", "ManagerSecondName", salary, experience);

            float realSalary = man.GetSalary();
            float expectedSalary = salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void ManagerTestInfo()
        {
            float salary = 1000;
            int experience = 7;
            string firstName = "DesFirstName";
            string secondName = "DesSecondName";
            Manager dev = new Manager(firstName, secondName, salary, experience);
            string manager = "He is a manager";

            string realSalary = dev.ToString();
            string expectedSalary = $"{firstName} {secondName}, manager:{manager}, experience:{experience}";

            Assert.AreEqual(expectedSalary, realSalary);
        }
    }
}
