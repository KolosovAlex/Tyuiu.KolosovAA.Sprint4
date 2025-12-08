using Tyuiu.Ko.Sprint4.Task6.V13.Lib;

namespace Tyuiu.KolosovAA.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] cars = ["Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi"];

            int result = ds.Calculate(cars);
            int wait = 4;

            Assert.AreEqual(wait, result);
        }
    }
}