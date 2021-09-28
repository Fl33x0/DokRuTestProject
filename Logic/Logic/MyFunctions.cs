using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class MyFunctions
    {
        // Task 4
        public static int DigitsSumm(int n) 
        {
            int result = n;

            while (result > 9)
            {
                result = 0;

                while (n != 0)
                {
                    result += n % 10;
                    n /= 10;
                }

                n = result;
            }
            

            return result;
        }

        // Task 5
        public static Dictionary<String, int> CentsToCoins(double cents) 
        {
            Dictionary<string, int> coinsDictionary = new Dictionary<string, int>(4);

            coinsDictionary.Add("Quarters", 0);
            coinsDictionary.Add("Dimes", 0);
            coinsDictionary.Add("Nickels", 0);
            coinsDictionary.Add("Pennies", 0);

            if (cents <= 0)
            {
                return coinsDictionary;
            }

            if (cents / 25 >= 1)
            {
                coinsDictionary["Quarters"] = (int)(cents / 25);
                cents = cents - 25 * (int)(cents / 25);
            }

            if (cents / 10 >= 1)
            {
                coinsDictionary["Dimes"] = (int)(cents / 10);
                cents = cents - 10 * (int)(cents / 10);
            }

            if (cents / 5 >= 1)
            {
                coinsDictionary["Nickels"] = (int)(cents / 5);
                cents = cents - 5 * (int)(cents / 5);
            }

            if (cents >= 1)
            {
                coinsDictionary["Pennies"] = (int)cents;
            }

            return coinsDictionary;
        }

        // Task 6
        public static int GetBiggestNumber(int number) 
        {
            int numberLength = number.ToString().Length;

            int[] digitsArray = new int[numberLength];

            for (int i = 0; i < numberLength; i++)
            {
                digitsArray[i] = number % 10;
                number /= 10;
            }

            int temp;

            for (int i = 0; i < numberLength; i++)
            {
                for (int j = 0; j < numberLength; j++)
                {
                    if (digitsArray[i] > digitsArray[j])
                    {
                        temp = digitsArray[i];
                        digitsArray[i] = digitsArray[j];
                        digitsArray[j] = temp;
                    }
                }
            }

            string resultString = new string("");

            foreach (var item in digitsArray)
            {
                resultString = string.Concat(resultString, item.ToString());
            }

            int result;

            int.TryParse(resultString, out result);

            return result;
        }

        // Task 7
        /// <summary>
        /// Если нужна только сумма, то это индекс строки в кубе
        /// </summary>
        public static int TriangleStringSumm(int stringIndex) 
        {
            return (int)Math.Pow(stringIndex, 3);
        }

        // Task 8
        public static int GetFive()
        {
            string str = new string("aaaaa");
            return str.Length;
        }
    }
}
