using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseOOP;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class DeveloperUnitTest
    {
        [TestMethod]
        public void DeveloperTestSalaryLowExperience()
        {
            float salary = 1000;
            int experience = 1;
            Developer dev = new Developer("DevFirstName", "DevSecondName", salary, experience,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void DeveloperTestSalaryUpLowExperience()
        {
            float salary = 1000;
            int experience = 3;
            Developer dev = new Developer("DevFirstName", "DevSecondName", salary, experience,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = salary + 200;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void DeveloperTestSalaryBigExperience()
        {
            float salary = 1000;
            int experience = 7;
            Developer dev = new Developer("DevFirstName", "DevSecondName", salary, experience,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = salary * 1.2f + 500;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Experience is wrong number.")]
        public void DeveloperWrongExperience()
        {
            float salary = 1000;
            int experience = -1;
            Developer dev = new Developer("DevFirstName", "DevSecondName", salary, experience,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = salary * 1.2f + 500;

            Assert.AreEqual(expectedSalary, realSalary);
        }


        [TestMethod]
        public void DeveloperTestInfo()
        {
            float salary = 1000;
            int experience = 7;
            string firstName = "DevFirstName";
            string secondName = "DevSecondName";
            string managerSecond = "ManagerSecondName";
            Developer dev = new Developer(firstName, secondName, salary, experience,
                new Manager("ManagerFirstName", managerSecond, 2000, 5));

            string realSalary = dev.ToString();
            string expectedSalary = $"{firstName} {secondName}, manager:{managerSecond}, experience:{experience}";

            Assert.AreEqual(expectedSalary, realSalary);
        }
    }
}
