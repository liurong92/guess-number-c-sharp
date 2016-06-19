namespace GuessNumber
{
    public class JudgeNumber
    {
        public string GetScore(int[] systemNumber, int[] inputNumber)
        {
            int resultA = 0;
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (inputNumber[i] == systemNumber[i])
                {
                    resultA++;
                }
            }
            return resultA.ToString() + "A0B";
        }
    }
}
