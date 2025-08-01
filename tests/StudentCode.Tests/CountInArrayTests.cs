public class CountInArrayTests
{
    [Fact]
    public void CountInArray_ReturnsCorrectCount()
    {
        Assert.Equal(3, StudentCode.CountInArray(new int[] { 1, 2, 1, 1, 3 }, 1));
    }
}
