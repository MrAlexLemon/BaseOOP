using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseOOP;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class DesignerUnitTest
    {
        [TestMethod]
        public void DesignerTestSalaryLowExperience()
        {
            float salary = 1000;
            int experience = 1;
            float effective = 0.123f;
            Designer dev = new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = salary+salary*effective;

            Assert.AreEqual(expectedSalary, realSalary);
        }


        [TestMethod]
        public void DesignerTestSalaryMidExperience()
        {
            float salary = 1000;
            int experience = 4;
            float effective = 0.95f;
            Designer dev = new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = 200 + salary * effective+salary;

            Assert.AreEqual(expectedSalary, realSalary);
        }


        [TestMethod]
        public void DesignerTestSalaryBigExperience()
        {
            float salary = 1000;
            int experience = 7;
            float effective = 0.95f;
            Designer dev = new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = salary*1.2f +500 + salary * effective;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Effective coef is wrong number.")]
        public void DesignerWrongEffectiveCoef()
        {
            float salary = 1000;
            int experience = 7;
            float effective = 2;
            Designer dev = new Designer("DesFirstName", "DesSecondName", salary, experience, effective,
                new Manager("ManagerFirstName", "ManagerSecondName", 2000, 5));

            float realSalary = dev.GetSalary();
            float expectedSalary = salary * 1.2f + 500 + salary * effective;

            Assert.AreEqual(expectedSalary, realSalary);
        }

        [TestMethod]
        public void DesignerTestInfo()
        {
            float salary = 1000;
            int experience = 7;
            string firstName = "DesFirstName";
            string secondName = "DesSecondName";
            float effective = 0.5f;
            string managerSecond = "ManagerSecondName";
            Designer dev = new Designer(firstName, secondName, salary, experience,effective,
                new Manager("ManagerFirstName", managerSecond, 2000, 5));

            string realSalary = dev.ToString();
            string expectedSalary = $"{firstName} {secondName}, manager:{managerSecond}, experience:{experience}";

            Assert.AreEqual(expectedSalary, realSalary);
        }
    }
}
