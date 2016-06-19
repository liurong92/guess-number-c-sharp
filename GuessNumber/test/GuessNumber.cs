using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessNumber.test
{
    [TestClass]
    public class GuessNumber
    {
        [TestMethod]
        public void should_return_4A0B_when_system_number_is_1234_and_input_number_is_1234()
        {
            var JudgeNumber = new JudgeNumber();
            Assert.AreEqual("4A0B", JudgeNumber.GetScore(new[] {1,2,3,4}, new[] {1,2,3,4}));
        }

        [TestMethod]
        public void should_return_0A0B_when_system_number_is_1234_and_input_number_is_5678()
        {
            var JudgeNumber = new JudgeNumber();
            Assert.AreEqual("0A0B", JudgeNumber.GetScore(new[] {1,2,3,4}, new[] {5,6,7,8}));
        }
    }
}