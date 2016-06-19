namespace GuessNumber
{
    public class JudgeNumber
    {
        public string GetScore(int[] systemNumber, int[] inputNumber)
        {
            int resultA = 0;
            int resultB = 0;
            for (int i = 0; i < systemNumber.Length; i++)
            {
                if (systemNumber[i] == inputNumber[i])
                {
                    resultA++;
                }

                for (int j = 0; j < inputNumber.Length; j++)
                {
                    if (inputNumber[j] == systemNumber[i])
                    {
                        resultB++;
                    }
                }
            }
            return string.Format("{0}A{1}B", resultA, resultB-resultA);
        }
    }
}
