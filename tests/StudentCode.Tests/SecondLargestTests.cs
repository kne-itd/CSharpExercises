public class SecondLargestTests
{
    [Fact]
    public void SecondLargest_ReturnsCorrectValue()
    {
        Assert.Equal(7, StudentCode.SecondLargest(new int[] { 3, 7, 9, 2 }));
    }
}
