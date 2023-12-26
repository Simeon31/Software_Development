using System;
using System.Text;

namespace Magic_Numbers.Model
{
    class MagicalNumbers
    {
        private StringBuilder magicalNumbers;

        public MagicalNumbers()
        {
            magicalNumbers = new StringBuilder();
        }

        public void FindAllMagicNumbers(int magicalNumber)
        {
            int[] currentDigits = new int[6];

            for (int num = 1; num <= 999999; num++)
            {
                int tempNum = num;
                int product = 1;

                bool hasZero = false;

                for (int i = 0; i < 6; i++)
                {
                    int digit = tempNum % 10;

                    if (digit == 0)
                    {
                        hasZero = true;
                        break;
                    }

                    product *= digit;
                    tempNum /= 10;
                }

                if (!hasZero && product == magicalNumber)
                {
                    ConvertToDigitsArray(num, currentDigits);
                    AppendToMagicalNumbers(currentDigits);
                }
            }
        }

        private void ConvertToDigitsArray(int number, int[] digits)
        {
            for (int i = 5; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
        }

        private void AppendToMagicalNumbers(int[] digits)
        {
            for (int i = 0; i < 6; i++)
            {
                magicalNumbers.Append(digits[i]);
            }
            magicalNumbers.AppendLine();
        }

        public string GetMagicalNumbers()
        {
            return magicalNumbers.ToString();
        }
    }
}
