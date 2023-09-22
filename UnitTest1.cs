
namespace busGossip;

public class Tests
{
    [Test]
    public void WhenOneDriver_ShouldReturn1()
    {
        // arrange
        

        // act
        var result = Program.GetNumberOfStops(new List<int> { 1 });

        // assert
        Assert.That(result, Is.EqualTo(1));
    }
}

internal class Program
{
    internal static int GetNumberOfStops(List<int> list)
    {
        return 1;
    }
}