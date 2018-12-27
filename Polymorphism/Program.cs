using System;
using System.Collections.Generic;
using Moq;

namespace Polymorphism
{
    public class Employee
    {
        public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;

            string result = $"\nThis ANGRY EMPLOYEE worked {weeklyHours} hrs.Paid for 40 hrs at $ {wage}/hr=${salary}";

            Console.WriteLine($"\n{result}\n");

            return result;
        }
    }

    public class Contractor : Employee
    {
        public override string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;

            string result =
                $"\nThis HAPPY CONTRACTOR worked {weeklyHours} hrs.Paid for 40 hrs at $ {wage}/hr=${salary}";

            Console.WriteLine($"\n{result}\n");

            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            const int hours = 55, wage = 70;


            var mock = new Mock<Utils>();

            mock.Setup(m => m.GetEmployees()).Returns(() => new List<Employee> {new Employee(), new Contractor()});

            List<Employee> employees = mock.Object.GetEmployees();

            foreach (var employee in employees)
            {
                employee.CalculateWeeklySalary(hours, wage);
            }
        }
    }

    public class Utils
    {
        public virtual List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}