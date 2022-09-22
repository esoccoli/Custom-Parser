namespace ParserHW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the custom parser. ");
            Console.WriteLine();
            string inputInt = " ";
            string inputDouble = " ";
            // Prompts user for integer to convert
            while (inputInt != "quit")
            {
                Console.WriteLine("Enter an integer. ");
                inputInt = Console.ReadLine().Trim();

                if (inputInt == "quit")
                {
                    Console.WriteLine();

                    while (inputDouble != "quit")
                    {
                        Console.WriteLine("Enter a double. ");
                        inputDouble = Console.ReadLine().Trim();

                        if (inputDouble == "quit")
                        {
                            Console.WriteLine("Goodbye. ");
                            break;
                        }
                        else
                        {
                            double result = ParseToDouble(inputDouble);
                            Console.WriteLine($"Your number {result} divided by 2 is {result / 2}");
                            Console.WriteLine();
                        }
                        
                    }

                }
                else
                {
                    int result = ParseToInteger(inputInt);
                    Console.WriteLine($"Your number {result} divided by 2 is {result / 2}");
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Converts the given string to an integer.
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns>The inputted string as an integer</returns>
        public static int ParseToInteger(string strNum)
        {
            int resultInt = 0;
            bool isNegative = false;
            int tempInt = -1;

            // Checks each character in the string
            for (int i = strNum.Length - 1; i >= 0; i--)
            {
                char character = strNum[i];

                // Determines if the number is negative
                if (i == 0 && character == '-')
                {
                    isNegative = true;
                    continue;
                }
                else
                {
                    
                    switch (character)
                    {
                        case '0':
                            tempInt = 0;
                            break;

                        case '1':
                            tempInt = 1;
                            break;

                        case '2':
                            tempInt = 2;
                            break;

                        case '3':
                            tempInt = 3;
                            break;

                        case '4':
                            tempInt = 4;
                            break;

                        case '5':
                            tempInt = 5;
                            break;

                        case '6':
                            tempInt = 6;
                            break;

                        case '7':
                            tempInt = 7;
                            break;

                        case '8':
                            tempInt = 8;
                            break;

                        case '9':
                            tempInt = 9;
                            break;

                        default:
                            return int.MinValue;
                    }
                }

                int power = (strNum.Length - 1) - i;
                resultInt += tempInt * (int)Math.Pow(10, power);
                
                
            }

            if (isNegative)
            {
                resultInt *= -1;
            }

            return resultInt;
            
        }

        /// <summary>
        /// Converts the given string to a double
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns>The double value of the given string </returns>
        public static double ParseToDouble(string strNum)
        {
            double resultDouble = 0;
            bool isNegative = false;
            int tempInt = -1;

            string wholeNum = "";
            string decimalNum = "";

            int decimalIndex = strNum.IndexOf('.');
            if (decimalIndex == -1)
            {
                wholeNum = strNum;
            }
            else
            {
                wholeNum = strNum.Substring(0, decimalIndex);
                decimalNum = strNum.Substring(decimalIndex + 1);
            }
            
            int power = 0;

            // Checks each character in the string
            for (int i = wholeNum.Length - 1; i >= 0; i--)
            {
                char character = wholeNum[i];

                // Determines if the number is negative
                if (i == 0 && character == '-')
                {
                    isNegative = true;
                    continue;
                }
                else
                {

                    switch (character)
                    {
                        case '0':
                            tempInt = 0;
                            break;

                        case '1':
                            tempInt = 1;
                            break;

                        case '2':
                            tempInt = 2;
                            break;

                        case '3':
                            tempInt = 3;
                            break;

                        case '4':
                            tempInt = 4;
                            break;

                        case '5':
                            tempInt = 5;
                            break;

                        case '6':
                            tempInt = 6;
                            break;

                        case '7':
                            tempInt = 7;
                            break;

                        case '8':
                            tempInt = 8;
                            break;

                        case '9':
                            tempInt = 9;
                            break;

                        default:
                            return double.NaN;
                    }
                }

                power = wholeNum.Length - i - 1;

                //if (leftOrRight == "left")
                //{
                //    power *= -1;
                //}
                resultDouble += (tempInt * Math.Pow(10, power));
            }

            for (int i = decimalNum.Length -1; i >= 0; i--)
            {
                char character = decimalNum[i];

                switch (character)
                {
                    case '0':
                        tempInt = 0;
                        break;

                    case '1':
                        tempInt = 1;
                        break;

                    case '2':
                        tempInt = 2;
                        break;

                    case '3':
                        tempInt = 3;
                        break;

                    case '4':
                        tempInt = 4;
                        break;

                    case '5':
                        tempInt = 5;
                        break;

                    case '6':
                        tempInt = 6;
                        break;

                    case '7':
                        tempInt = 7;
                        break;

                    case '8':
                        tempInt = 8;
                        break;

                    case '9':
                        tempInt = 9;
                        break;

                    default:
                        return double.NaN;
                }

                power = -1 * (i + 1);
                resultDouble += tempInt * Math.Pow(10, power);
            }

            if (isNegative)
            {
                resultDouble *= -1;
            }

            return resultDouble;
        }
    }
}
