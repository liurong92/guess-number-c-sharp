using System;

namespace GuessNumber
{
    public class Generator
    {
        public string getRandomNumber()
        {
            string systemValue = string.Empty;
            while (systemValue.Length < 4)
            {
                var random = new Random();
                int randomNumber = random.Next(0, 10);
                if (!systemValue.Contains(randomNumber.ToString()))
                {
                    systemValue += randomNumber.ToString();
                }
            }
            return systemValue;
        }
    }
}
