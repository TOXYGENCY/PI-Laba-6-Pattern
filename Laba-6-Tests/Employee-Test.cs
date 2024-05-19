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
            Assert.IsTrue(emp.WorkYears == 0 && emp.Bonus == 0);
        }

        [TestMethod]
        public void Constructor_Success_case1()
        {
            var emp = new Employee(1);
            Assert.IsTrue(emp.WorkYears == 1 && emp.Bonus == 10);
        }

        [TestMethod]
        public void Constructor_Success_case2()
        {
            var emp = new Employee(2);
            Assert.IsTrue(emp.WorkYears == 2 && emp.Bonus == 20);
        }

        [TestMethod]
        public void Constructor_Success_case3()
        {
            var emp = new Employee(3);
            Assert.IsTrue(emp.WorkYears == 3 && emp.Bonus == 50);
        }



        // Auto assign bonus tests
        [TestMethod]
        public void AutoAssignBonus_Success_case0()
        {
            var emp = new Employee(1);
            emp.WorkYears = 0;
            emp.AutoAssignBonus();
            Assert.AreEqual(0, emp.Bonus);
        }

        [TestMethod]
        public void AutoAssignBonus_Success_case1()
        {
            var emp = new Employee(0);
            emp.WorkYears = 1;
            emp.AutoAssignBonus();
            Assert.AreEqual(10, emp.Bonus);
        }

        [TestMethod]
        public void AutoAssignBonus_Success_case2()
        {
            var emp = new Employee(0);
            emp.WorkYears = 2;
            emp.AutoAssignBonus();
            Assert.AreEqual(20, emp.Bonus);
        }

        [TestMethod]
        public void AutoAssignBonus_Success_case3()
        {
            var emp = new Employee(0);
            emp.WorkYears = 3;
            emp.AutoAssignBonus();
            Assert.AreEqual(50, emp.Bonus);
        }

    }
}
