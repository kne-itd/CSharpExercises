public class PalindromeTests
{
    [Fact]
    public void IsPalindrome_ReturnsTrueForPalindrome()
    {
        Assert.True(StudentCode.IsPalindrome("level"));
    }

    [Fact]
    public void IsPalindrome_ReturnsFalseForNonPalindrome()
    {
        Assert.False(StudentCode.IsPalindrome("banana"));
    }
}
