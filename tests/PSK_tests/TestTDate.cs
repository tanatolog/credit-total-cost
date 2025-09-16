using Xunit;

// “естирование класса TDate
public class TDateTests
{
    [Fact]
    public void Constructor_String_ParsesCorrectly()
    {
        var date = new TDate("15.09.2025");
        Assert.Equal(15, date.day);
        Assert.Equal(9, date.month);
        Assert.Equal(2025, date.year);
    }

    [Fact]
    public void Constructor_Int_ParsesCorrectly()
    {
        var date = new TDate(1, 1, 2000);
        Assert.Equal("01.01.2000", date.String());
    }

    [Theory]
    [InlineData(2024, 2, 29)] // високосный год
    [InlineData(2023, 2, 28)] // невисокосный год
    public void DaysInMonth_ReturnsCorrectValue(int year, int month, int expectedDays)
    {
        var date = new TDate(1, month, year);
        Assert.Equal(expectedDays, date.DaysinMonth());
    }

    [Fact]
    public void Quantity_BetweenDates_CalculatesCorrectly()
    {
        var date1 = new TDate("01.01.2024");
        var days = date1.Quantity(2, 1, 2024);
        Assert.Equal(1, days);
    }

    [Fact]
    public void DayName_ReturnsCorrectDayOfWeek()
    {
        var date = new TDate("16.09.2025"); // это вторник
        Assert.Equal("¬торник", date.DayName());
    }

    [Fact]
    public void Nonworking_ReturnsTrue_ForWeekend()
    {
        var date = new TDate("14.09.2025"); // воскресенье
        Assert.True(date.Nonworking());
    }

    [Fact]
    public void Nonworking_ReturnsTrue_ForHoliday()
    {
        var date = new TDate("09.05.2025"); // 9 ма€ Ц праздник
        Assert.True(date.Nonworking());
    }

    [Fact]
    public void String_ReturnsFormattedDate()
    {
        var date = new TDate(7, 3, 2025);
        Assert.Equal("07.03.2025", date.String());
    }
}
