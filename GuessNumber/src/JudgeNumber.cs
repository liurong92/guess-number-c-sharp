using System.Linq;

namespace GuessNumber
{
    public class JudgeNumber
    {
        readonly char[] systemNumbers;
        readonly char[] inputNumbers;

        public JudgeNumber(string system, string input)
        {
            systemNumbers = system.ToCharArray();
            inputNumbers = input.ToCharArray();
        }

        public string GetScore()
        {
            var resultA = 0;
            var resultB = 0;
            for (var i = 0; i < systemNumbers.Length; i++)
            {
                if (systemNumbers[i] == inputNumbers[i])
                {
                    resultA++;
                }
                resultB += inputNumbers.Count(inputNumber => inputNumber == systemNumbers[i]);
            }
            return string.Format("{0}A{1}B", resultA, resultB - resultA);
        }
    }
}
