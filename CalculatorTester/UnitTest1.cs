using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using htai;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }
        [
      TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [
      TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [
      TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [
      TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [
      TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\thb3\hoangtai\CalculatorTester\Data\TextData.csv",
            "TextData#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            Calculation c;
            int a, b, expected;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Calculation(a, b);
            Assert.AreEqual(expected, c.Execute(operation));
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\thb3\hoangtai\CalculatorTester\Data\testSoSanh.csv", DataAccessMethod.Sequential)]
        public void testHamSoSanh()
        {
            Calculation c;
            int actual, a, b, expected;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new Calculation(a, b);
            actual = c.SoSanh(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}