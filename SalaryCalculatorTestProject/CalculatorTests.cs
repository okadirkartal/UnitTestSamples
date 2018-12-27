using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        /*
         * To get hourlu,divide annual salary by 2080
         * $100,006 / 2080 = $48.08 hr
         *
         * To get annual,multiply hourlu by 2080
         * $48.08 * 2000 = $100,006.40
         */
        
        [TestMethod]
        public void AnnualSalaryTest()
        {
           //Arrange
            SalaryCalculator sc=new SalaryCalculator();


            //Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            //Assert
            Assert.AreEqual(104000,annualSalary); 
        }
        
        [TestMethod]
        public void HourlyWageTest()
        {
            //Arrange
            SalaryCalculator sc=new SalaryCalculator();


            //Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            //Assert
            Assert.AreEqual(25,hourlyWage); 
        }
    }
}