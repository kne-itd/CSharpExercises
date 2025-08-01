public class ReverseArrayTests
{
    [Fact]
    public void Reverse_ReturnsReversedArray()
    {
        Assert.Equal(new int[] { 3, 2, 1 }, StudentCode.Reverse(new int[] { 1, 2, 3 }));
    }
}
