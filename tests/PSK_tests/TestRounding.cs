using Xunit;

public class RoundingTests
{
    // RoundUp
    [Theory]
    [InlineData(1.2345, 2, 1.24)] // округление вверх до 2 знаков
    [InlineData(1.2301, 2, 1.24)]
    [InlineData(-1.2345, 2, -1.23)] // отрицательное число округляется "вверх" по модулю
    [InlineData(123, -1, 130)]      // округление до десятков
    [InlineData(123, -2, 200)]      // округление до сотен
    public void RoundUp_ReturnsCorrectValue(decimal number, int places, decimal expected)
    {
        decimal result = Rounding.RoundUp(number, places);
        Assert.Equal(expected, result);
    }

    // RoundDown
    [Theory]
    [InlineData(1.2345, 2, 1.23)] // округление вниз до 2 знаков
    [InlineData(1.2399, 2, 1.23)]
    [InlineData(-1.2345, 2, -1.24)] // отрицательное число округляется "вниз" по модулю
    [InlineData(123, -1, 120)]      // округление до десятков
    [InlineData(123, -2, 100)]      // округление до сотен
    public void RoundDown_ReturnsCorrectValue(decimal number, int places, decimal expected)
    {
        decimal result = Rounding.RoundDown(number, places);
        Assert.Equal(expected, result);
    }

    // RoundFactor
    [Theory]
    [InlineData(0, 1)]     // 10^0 = 1
    [InlineData(1, 10)]    // 10^1 = 10
    [InlineData(2, 100)]   // 10^2 = 100
    [InlineData(-1, 0.1)]  // 10^-1 = 0.1
    [InlineData(-2, 0.01)] // 10^-2 = 0.01
    public void RoundFactor_ReturnsCorrectValue(int places, decimal expected)
    {
        decimal result = Rounding.RoundFactor(places);
        Assert.Equal(expected, result);
    }
}
