using System;

namespace WritingFunctions
{
    class Program
    {
        static int Factorial(int number)
            {
                if (number < 1)
                {
                    return 0;
                }
                else if (number == 1)
                {
                    return 1;
                }
                else
                {
                    checked
                    {
                        return number * Factorial(number - 1);
                    }
                }
            }

        static void RunFactorial()
            {
                for (int i = 1; i < 15; i++)
                {
                    try
                    {
                        Console.WriteLine($"{i}! = {Factorial(i):N0}");
                    }
                    catch (System.OverflowException)
                    {
                        System.Console.WriteLine($"{i}! is too big for a 32-bit integer. ");
                    }
                }
            }
            /// <summary>
            /// Передайте 32-битное целое число, и оно будет преобразованно
            /// в его порядковый эквивалент
            /// </summary>
            /// <param name="number"> Число - это кардинальное значение,
            /// например 1, 2, 3 и т.д.</param>
            /// <returns></returns> Число как порядковое значение,
            /// например 1-й, 2-й, 3-й и т.д.
        static string CardinalToOrdinal(int number)
        {
            
            switch (number)
            {
                case 11: // case from 11 to 13
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;

                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd", 
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
                }
            }

        static void RunCurdinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                System.Console.Write($"{CardinalToOrdinal(number)} ");
            }
            System.Console.WriteLine();
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": // Швейцария
                    rate = 0.08M;
                    break;
                case "DK": // Дания
                case "NO": // Норвегия
                    rate = 0.25M;
                    break;
                case "GB": // Великобритания
                case "FR": // Франция
                    rate = 0.2M;
                    break;
                case "HU": // Венгрия
                    rate = 0.27M;
                    break;
                case "OR": // Орегон
                case "AK": // Аляска
                case "MT": // Монтана
                    rate = 0.0M;
                    break;
                case "ND": // Северная Дакота
                case "WI": // Висконсин
                case "ME": // Мэриленд
                case "VA": // Вирджиния
                    rate = 0.05M;
                    break;
                case "CA": // Калифорния
                    rate = 0.0825M;
                    break;
                default: // большинство штатов США
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }

        static void RunCalculateTax()
        {
            System.Console.WriteLine("Enter an amount: ");
            string amountInText = System.Console.ReadLine();

            System.Console.WriteLine("Enter a two-letter region code: ");
            string region = System.Console.ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                System.Console.WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                System.Console.WriteLine("You did not enter a valid amount!");
            }
        }

        static void TimesTable(byte number)
        {
            System.Console.WriteLine($"This is the {number} times table");
            for (int row = 1; row <= 12; row++)
            {
                System.Console.WriteLine($"{row} x {number} = {row * number}");
            }
            System.Console.WriteLine();
        }

        static void RunTimesTables()
        {
            bool isNumber;
            do
            {
                System.Console.Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(Console.ReadLine(), out byte number);


                if (isNumber == true)
                {
                    TimesTable(number);
                }
                else
                {
                    System.Console.WriteLine("You did not enter a valid numer!");
                }
            } 
                while (isNumber);
        }

        static void Main(string[] args)
        {
            //RunTimesTables();
            //RunCalculateTax();
            //RunCurdinalToOrdinal();
            RunFactorial();
        }
    }
}
