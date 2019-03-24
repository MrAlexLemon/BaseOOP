using System;
using System.Collections.Generic;
using System.Text;

namespace BaseOOP
{
    public abstract class Employee
    {
        private string _firstName;
        private string _secondName;
        private float _salary;
        private int _experience;
        private Manager manager;

        public string FirstName {
            get
            {
                return _firstName;
            }
            protected set
            {
                if(value=="" || value==null)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be > 0 symbols");
                else
                    _firstName = value;
            }
        }
        public string SecondName {
            get
            {
                return _secondName;
            }
            protected set
            {
                if (value == "" || value == null)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be > 0 symbols");
                else
                    _secondName = value;
            }
        }
        public float Salary {
            get
            {
                return _salary;
            }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be > 0");
                else
                    _salary = value;
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be > 0");
                else
                    _experience = value;
            }
        }


        public Manager Manager
        {
            get { return manager; }
            protected set { manager = value; }
        }


        public Employee(string firstName, string secondName,float salary, int experience,Manager manager)
        {
            FirstName = firstName;
            SecondName = secondName;
            Salary = salary;
            Experience = experience;
            Manager = manager;
        }

        public abstract float GetSalary();
        protected float GetBonus()
        {
            float tempSalary = 0.0f;

            if (_experience > 2 && _experience <= 5)
                tempSalary = _salary + 200;
            else if (_experience > 5)
                tempSalary = _salary * 1.2f + 500;
            else
                tempSalary = Salary;
            return tempSalary;
        }
        public override string ToString()
        {
            string temp = "He is a manager";
            if (manager != null)
                temp = manager.SecondName;

            return $"{_firstName} {_secondName}, manager:{temp}, experience:{_experience}";
        }
    }
}
