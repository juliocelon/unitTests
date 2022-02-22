using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestSum()
        {
            // Arrange
            int a = 3;
            int b = 5;
            int expected = 8;

            // Act
            int result = MyProgram.Program.Sum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataRow(16, 2, 18)]
        [DataRow(6, 2, 8)]
        [TestMethod]
        public void TestSum2(int a, int b, int expected)
        {
            // Act
            int result = MyProgram.Program.Sum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLoginCorrect()
        {
            // Arrange
            string user = "user";
            string pwd = "pwd";
            bool expected = true;

            // Act
            bool result = MyProgram.Program.Login(user,pwd);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataRow("user", "pwd2", false)]
        [TestMethod]
        public void TestLoginIncorrect(string user, string pwd, bool expected)
        {
            // Act
            bool result = MyProgram.Program.Login(user, pwd);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}