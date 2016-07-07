using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessNumber.test
{
    [TestClass]
    public class GeneratorTest
    {   
        [TestMethod]
        public void should_return_the_value_length_is_4()
        {
            var Generator = new Generator();
            var result = Generator.getRandomNumber();
            Assert.AreEqual(4, result.ToCharArray().Length);
        }

        [TestMethod]
        public void should_return_the_value_is_number()
        {
            var Generator = new Generator();
            var result = Generator.getRandomNumber();
            var resultArray = result.ToCharArray();

            int number = 0;
            for (var i = 0; i < resultArray.Length; i++)
            {
                for (var j = 0; j < resultArray.Length; j++)
                {
                    if (resultArray[i] == resultArray[j] && i != j)
                    {
                        number++;
                    }
                }
            }

            Assert.AreEqual(0, number);

        }
    }
}