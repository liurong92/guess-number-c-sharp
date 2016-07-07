using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessNumber.test
{
    [TestClass]
    public class JudgeNumberTest
    {   
        [TestMethod]
        public void should_return_1A0B_when_system_number_is_1234_and_input_number_is_1567()
        {
            var JudgeNumber = new JudgeNumber("1234", "1567");
            Assert.AreEqual("1A0B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_2A0B_when_system_number_is_1234_and_input_number_is_1256()
        {
            var JudgeNumber = new JudgeNumber("1234", "1256");
            Assert.AreEqual("2A0B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_3A0B_when_system_number_is_1234_and_input_number_is_1235()
        {
            var JudgeNumber = new JudgeNumber("1234", "1235");
            Assert.AreEqual("3A0B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_4A0B_when_system_number_is_1234_and_input_number_is_1234()
        {
            var JudgeNumber = new JudgeNumber("1234", "1234");
            Assert.AreEqual("4A0B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_0A1B_when_system_number_is_1234_and_input_number_is_4567()
        {
            var JudgeNumber = new JudgeNumber("1234", "4567");
            Assert.AreEqual("0A1B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_0A2B_when_system_number_is_1234_and_input_number_is_4356()
        {
            var JudgeNumber = new JudgeNumber("1234", "4356");
            Assert.AreEqual("0A2B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_0A3B_when_system_number_is_1234_and_input_number_is_4325()
        {
            var JudgeNumber = new JudgeNumber("1234", "4325");
            Assert.AreEqual("0A3B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_0A4B_when_system_number_is_1234_and_input_number_is_4321()
        {
            var JudgeNumber = new JudgeNumber("1234", "4321");
            Assert.AreEqual("0A4B", JudgeNumber.GetScore());
        }

        [TestMethod]
        public void should_return_1A1B_when_system_number_is_1234_and_input_number_is_1356()
        {
            var JudgeNumber = new JudgeNumber("1234", "1356");
            Assert.AreEqual("1A1B", JudgeNumber.GetScore());
        }
    }
}