
using System;
using Tyuiu.KolosovAA.Sprint4.Task6.V13.Lib;

namespace Tyuiu.KolosovAA.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void testics()
        {
            DataService ds = new DataService();

            string[] matrix = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            Assert.AreEqual(4, ds.Calculate(matrix));
        }
    }
}
