using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PI_Laba_6_Pattern;

namespace PI_Laba_6_Pattern.Tests
{
    [TestClass]
    public class Employee_Test
    {
        [TestMethod]
        public void SetBonus_Success()
        {
            //Arrange
            var emp = new Employee(0);

            //Act
            emp.SetBonus(50000);

            //Assert
            Assert.AreEqual(50000, emp.Bonus);
        }

        // Constructor tests
        [TestMethod]
        public void Constructor_Success_case0()
        {
            var emp = new Employee(0);
            Assert.AreEqual(0, emp.Bonus);
        }

        [TestMethod]
        public void Constructor_Success_case1()
        {
            var emp = new Employee(1);
            Assert.AreEqual(10, emp.Bonus);
        }

        [TestMethod]
        public void Constructor_Success_case2()
        {
            var emp = new Employee(2);
            Assert.AreEqual(20, emp.Bonus);
        }

        [TestMethod]
        public void Constructor_Success_case3()
        {
            var emp = new Employee(3);
            Assert.AreEqual(50, emp.Bonus);
        }



        /*
        [TestMethod]
        public void AutoAssignBonus_Success_case0() 
        {
            var emp = new Employee(0);
            emp.AutoAssignBonus();
            Assert.AreEqual(0, emp.Bonus);
        }

        [TestMethod]
        public void AutoAssignBonus_Success_case1()
        {
            var emp = new Employee(1);
            emp.AutoAssignBonus();
            Assert.AreEqual(10, emp.Bonus);
        }

        [TestMethod]
        public void AutoAssignBonus_Success_case2()
        {
            var emp = new Employee(2);
            emp.AutoAssignBonus();
            Assert.AreEqual(20, emp.Bonus);
        }

        [TestMethod]
        public void AutoAssignBonus_Success_case3()
        {
            var emp = new Employee(3);
            emp.AutoAssignBonus();
            Assert.AreEqual(50, emp.Bonus);
        }*/

    }
}
