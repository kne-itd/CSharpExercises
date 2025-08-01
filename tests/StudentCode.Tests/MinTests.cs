public class MinTests
{
    [Fact]
    public void Min_ReturnsSmallestNumber()
    {
        Assert.Equal(2, StudentCode.Min(new int[] { 5, 7, 2, 9 }));
    }
}
