using Newtonsoft.Json.Linq;

namespace PI_Laba_6_Pattern
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
            Assert.IsTrue(emp.WorkYears == 0 && emp.Bonus == 0 && emp.IsLeaf == true);
        }

        [TestMethod]
        public void Constructor_Success_case1()
        {
            var emp = new Employee(1);
            Assert.IsTrue(emp.WorkYears == 1 && emp.Bonus == 10 && emp.IsLeaf == true);
        }

        [TestMethod]
        public void Constructor_Success_case2()
        {
            var emp = new Employee(2);
            Assert.IsTrue(emp.WorkYears == 2 && emp.Bonus == 20 && emp.IsLeaf == true);
        }

        [TestMethod]
        public void Constructor_Success_case3()
        {
            var emp = new Employee(3);
            Assert.IsTrue(emp.WorkYears == 3 && emp.Bonus == 50 && emp.IsLeaf == true);
        }

        [TestMethod]
        [DataRow((sbyte)10)]
        [DataRow((sbyte)14)]
        [DataRow((sbyte)43)]
        public void Constructor_Success_case4(sbyte value)
        {
            var emp = new Employee(value);
            Assert.IsTrue(emp.WorkYears == value && emp.Bonus == 50 && emp.IsLeaf == true);
        }

        [TestMethod]
        [DataRow((sbyte)-1)]
        [DataRow((sbyte)-10)]
        public void Constructor_Failure(sbyte value)
        {
            Assert.ThrowsException<ArgumentException>(() => new Employee(value));
        }


    }
}
