public class AverageTests
{
    [Fact]
    public void Average_ReturnsCorrectAverage()
    {
        Assert.Equal(4.5, StudentCode.Average(4, 5), 1);
    }
}
