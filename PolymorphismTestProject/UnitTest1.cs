using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace PolymorphismTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee employee = new Employee();

            string expectedResponse =
                $"\nThis ANGRY EMPLOYEE worked {weeklyHours} hrs.Paid for 40 hrs at $ {wage}/hr=${salary}";

            //Act
            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            //Assert
            Assert.AreEqual(response, expectedResponse);
        }


        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursReturns3850Dollars()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor contractor = new Contractor();

            string expectedResponse =
                $"\nThis HAPPY CONTRACTOR worked {weeklyHours} hrs.Paid for 40 hrs at $ {wage}/hr=${salary}";

            //Act
            string response = contractor.CalculateWeeklySalary(weeklyHours, wage);

            //Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursDoesNotReturnCorrectString()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee employee = new Employee();

            string expectedResponse =
                $"\nCase 1 This ANGRY EMPLOYEE worked {weeklyHours} hrs.Paid for 40 hrs at $ {wage}/hr=${salary}";

            //Act
            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            //Assert
            Assert.AreNotEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursDoesNotReturnCorrectString()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor contractor = new Contractor();

            string expectedResponse =
                $"\nCase 2 This HAPPY CONTRACTOR worked {weeklyHours} hrs.Paid for 40 hrs at $ {wage}/hr=${salary}";

            //Act
            string response = contractor.CalculateWeeklySalary(weeklyHours, wage);

            //Assert
            Assert.AreNotEqual(response, expectedResponse);
        }
    }
}