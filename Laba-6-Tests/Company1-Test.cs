using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Laba_6_Pattern
{
    [TestClass]
    public class Company1_Test
    {
        [TestMethod]
        public void Constructor_Success()
        {
            var c = new Company1();
            Assert.IsFalse(c.IsLeaf);
            Assert.IsNotNull(c.ChildrenList);
        }

        [TestMethod]
        [DataRow((sbyte)0)]
        [DataRow((sbyte)1)]
        [DataRow((sbyte)2)]
        [DataRow((sbyte)3)]
        [DataRow((sbyte)43)]
        public void AddComp_Success(sbyte WY)
        {
            var c = new Company1();
            var emp = new Employee(WY);
            c.AddComp(emp);
            Assert.AreEqual(c.ChildrenList.Find(e => e == emp), emp);
            Assert.IsNotNull(c.ChildrenList);
        }

        [TestMethod]
        public void AddComp_Fail()
        {
            var c = new Company1();
            Assert.ThrowsException<ArgumentNullException>(() => c.AddComp(null));
        }

        [TestMethod]
        public void RemoveComp_Success()
        {
            var c = new Company1();

            var emp1 = new Employee(0);

            c.AddComp(emp1);
            c.AddComp(new Employee(2));
            c.AddComp(new Employee(3));

            c.RemoveComp(emp1);

            Assert.IsFalse(c.ChildrenList.Contains(emp1));
            Assert.IsNotNull(c.ChildrenList);
        }

        [TestMethod]
        public void RemoveComp_Failure()
        {
            var c = new Company1();
            c.AddComp(new Employee(2));
            Assert.ThrowsException<ArgumentNullException>(() => c.RemoveComp(null));
        }
    }
}
