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

        [TestMethod]
        public void should_return_0A4B_when_system_number_is_1234_and_input_number_is_4321()
        {
            var JudgeNumber = new JudgeNumber();
            Assert.AreEqual("0A4B", JudgeNumber.GetScore(new[] {1,2,3,4}, new[] {4,3,2,1}));
        }

        [TestMethod]
        public void should_return_1A1B_when_system_number_is_1234_and_input_number_is_1256()
        {
            var JudgeNumber = new JudgeNumber();
            Assert.AreEqual("1A1B", JudgeNumber.GetScore(new[] {1,2,3,4}, new[] {1,3,5,6}));
        }
    }
}