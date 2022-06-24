namespace PrimeNumbersLibUnitTests;

public class UnitTest1
{
    [Fact]
    public void Test30()
    {
        //Given
        int a = 30;
        string expected = "простой множитель 30: 5 x 3 x 2";
        var primeNumbers = new PrimeNumbers();

        //When
        string actual = primeNumbers.GetPrimeNumbers(a);

        //Then
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test7()
    {
        //Given
        int a = 7;
        string expected = "простой множитель 7: 7";
        var primeNumbers = new PrimeNumbers();

        //When
        string actual = primeNumbers.GetPrimeNumbers(a);

        //Then
        Assert.Equal(expected, actual);
    }
}