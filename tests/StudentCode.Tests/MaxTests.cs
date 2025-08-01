public class MaxTests
{
    [Fact]
    public void Max_ReturnsLargerNumber()
    {
        Assert.Equal(9, StudentCode.Max(4, 9));
    }
}
