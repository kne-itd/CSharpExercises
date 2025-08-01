public class TemperatureTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    public void CelsiusToFahrenheit_Works(double celsius, double expected)
    {
        Assert.Equal(expected, StudentCode.CelsiusToFahrenheit(celsius), 1);
    }
}
