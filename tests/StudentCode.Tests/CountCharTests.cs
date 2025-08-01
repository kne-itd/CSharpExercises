public class CountCharTests
{
    [Fact]
    public void CountOccurrences_ReturnsCorrectCount()
    {
        Assert.Equal(2, StudentCode.CountOccurrences("banana", 'a'));
    }
}
