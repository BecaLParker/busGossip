
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
    
    [Test]
    public void WhenTwoDriversMeet_ShouldReturnNumberOfStops()
    {
        // arrange
        

        // act
        var result = Program.GetNumberOfStops(new List<int> { 3, 1 }, new List<int> { 2, 1 });

        // assert
        Assert.That(result, Is.EqualTo(2));
    }
}

internal class Program
{
    internal static int GetNumberOfStops(params List <int>[] routes)
    {
        if (routes.Length == 1)
        {
            return 1;
        }
        var route1 = routes[0];
        var route2 = routes[1];

        var zippedRoutes = route1.Zip(route2).ToList();
        var meetingPlace = zippedRoutes.FirstOrDefault(x => x.First == x.Second);

        return zippedRoutes.IndexOf(meetingPlace) + 1;
    }
}