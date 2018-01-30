using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatwhiteTests
    {
        [TestMethod()]
        public void MlMælkTest()
        {
            //Arrange
            var fw = new Flatwhite();

            //Act
            int result = fw.MlMælk();

            //Assert
            Assert.AreEqual(160, result);
        }

        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var fw = new Flatwhite();

            //Act
            int result = fw.Pris();

            //Assert
            Assert.AreEqual(45,result);
        }

        [TestMethod()]
        public void StyrkeTest()
        {
            //Arrange
            var fw = new Flatwhite();

            //Act
            string result = fw.Styrke();

            //Assert
            Assert.AreEqual("mild", result);
        }
    }
}