namespace ATM_App.Tests
{
    [TestClass]
    public class MoneyControllerTests : MoneyController
    {
        [TestMethod]
        public void TestMethod1()
        {
            string money = "500";
            bool expected = true;

            bool actual = CheckFormat(money);

            Assert.AreEqual(expected, actual);
        }
    }
}