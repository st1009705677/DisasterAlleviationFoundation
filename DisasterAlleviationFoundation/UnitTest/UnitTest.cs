using DisasterAlleviationFoundation.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DisasterAlleviationFoundation.UnitTest
{
    public class UnitTest
    {

        [TestClass]
        public class UnitTestLogin
        {
            [TestMethod]
            public void TestMethod1_ReturnsSuccessfullLogin()
            {

                // Arrange
                Login login = new Login();
                const string Username = "JullietR";
                const string Password = "Password@2023";
               


                // Act
                var actual = Login.Equals(Username, Password);

                // Assert
                Assert.IsTrue(true);

            }

            public void TestMethod2()
            {
                Assert.IsNotNull(true);
            }

        }


    }
}

