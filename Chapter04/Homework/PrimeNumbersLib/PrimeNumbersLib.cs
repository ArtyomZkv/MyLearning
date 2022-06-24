namespace PrimeNumbersLib
{
    public class PrimeNumbers
    {
        List<int> primeNumbersList = new List<int>()
        {
            2, 3, 5, 7, 11, 13, 17
        };
        public string GetPrimeNumbers(int number)
        {
            string currentNumbers = $"простой множитель {number}: ";

            for (int i = primeNumbersList.Count - 1; i >= 0; i--)
            {
                while (number % primeNumbersList[i] == 0)
                {
                    number = number / primeNumbersList[i];
                    currentNumbers += $"{primeNumbersList[i]} ";
                    if (number == 1)
                    {
                        break;
                    }
                    currentNumbers += "x ";
                }
            }
            return currentNumbers;
        }
    }
}
