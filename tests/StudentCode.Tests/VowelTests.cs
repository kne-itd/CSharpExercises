public class VowelTests
{
    [Fact]
    public void CountVowels_ReturnsCorrectNumber()
    {
        Assert.Equal(3, StudentCode.CountVowels("Hello"));
    }
}
