using System;

namespace SerIizationCopyPro.Models
{
    [Serializable]
    public class Employee : Person
    {
        public int Salary;
        public Employee() { }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
        }
    }
}
