public class SumTests
{
    [Fact]
    public void Sum_ReturnsCorrectSum()
    {
        Assert.Equal(7, StudentCode.Sum(3, 4));
    }
}
