using System;
using System.Collections.Generic;
using System.Text;

namespace BaseOOP
{
    public class Designer:Employee
    {
        private float _effectivenessCoefficient;
        public float EffectivenessCoefficient
        {
            get
            {
                return _effectivenessCoefficient;
            }
            private set
            {
                if (value > 0.0f && value < 1.0)
                    _effectivenessCoefficient = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 1.");
            }
        }


        public Designer(string firstName, string secondName, float salary, int experience, float effective, Manager manager)
            : base(firstName, secondName, salary, experience, manager)
        {
            EffectivenessCoefficient = effective;
        }

        public override float GetSalary()
        {
            return (GetBonus() + Salary * EffectivenessCoefficient);
        }
    }
}
