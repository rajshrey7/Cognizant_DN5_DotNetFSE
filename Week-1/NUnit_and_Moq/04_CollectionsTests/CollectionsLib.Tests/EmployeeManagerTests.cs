using CollectionsLib;
using NUnit.Framework;
using System.Collections.Generic;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new EmployeeManager();
        }

        [Test]
        public void GetEmployees_ReturnsAllEmployees()
        {
            List<Employee> employees = manager.GetEmployees();

            Assert.AreEqual(4, employees.Count);
            Assert.AreEqual("John", employees[0].EmpName);
            Assert.AreEqual("Mary", employees[1].EmpName);
            Assert.AreEqual("Steve", employees[2].EmpName);
            Assert.AreEqual("Allen", employees[3].EmpName);
        }

        [Test]
        public void GetEmployeesWhoJoinedInPreviousYears_ReturnsEmployees()
        {
            List<Employee> employees = manager.GetEmployeesWhoJoinedInPreviousYears();

            Assert.AreEqual(4, employees.Count);

            foreach (Employee emp in employees)
            {
                Assert.IsTrue(emp.DOJ < System.DateTime.Now);
            }
        }
    }
}