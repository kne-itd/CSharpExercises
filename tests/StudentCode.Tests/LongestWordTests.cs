public class LongestWordTests
{
    [Fact]
    public void LongestWord_ReturnsCorrectWord()
    {
        Assert.Equal("programmering", StudentCode.LongestWord("C# er sjov programmering"));
    }
}
