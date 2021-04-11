using CopyInheritPro.Interfaces;

namespace CopyInheritPro.Models
{
    //we inherit class Employee from the Person 
    public class Employee : Person, IDeepCopyable<Employee>
    {
        public int Salary;
        //it will call CopyTo  with call the Person class
        public void CopyTo(Employee target)
        {
            base.CopyTo(target);
            target.Salary = Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
        }
    }
}
