namespace FactorialLibrary.Tests;

public class FactorialServiceTests
{
    [Fact]
    public void Test1()
    {
        Assert.Throws<InvalidOperationException>(()=>{
            var result = FactorialService.Factorial(-1);
        });
    }
}
