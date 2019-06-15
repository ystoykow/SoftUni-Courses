namespace _03._TakeSkip_Rope
{
    using System;
    using System.Collections.Generic;

    public class TakeSkipRope
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();
            List<int> numbersList = new List<int>();
            List<char> charList = new List<char>();
            string result = string.Empty;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (char.IsDigit(inputText[i]))
                {
                    int currentDigit = (int)char.GetNumericValue(inputText[i]);
                    numbersList.Add(currentDigit);
                }
                else
                {
                    charList.Add(inputText[i]);
                }
            }

            int sum = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                int currentNumber = numbersList[i];
                if (i % 2 == 0)
                {
                    for (int j = 0; j < currentNumber; j++)
                    {
                        if (j + sum < charList.Count)
                        {
                            result += charList[j + sum];
                        }
                    }
                }

                sum += currentNumber;
            }

            Console.WriteLine(result);
        }
    }
}
