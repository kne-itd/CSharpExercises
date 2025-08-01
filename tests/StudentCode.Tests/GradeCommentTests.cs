public enum Grade { A, B, C, D, F }

public class GradeCommentTests
{
    [Fact]
    public void GetComment_ReturnsCorrectMessage()
    {
        Assert.Equal("Godt arbejde!", StudentCode.GetComment(Grade.A));
        Assert.Equal("Du skal forbedre dig", StudentCode.GetComment(Grade.F));
    }
}
