
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
       for (int i = 0; i < route1.Count; i++)
       {
           if (route1[i] == route2[i])
           {
               return i + 1;
           }
       }

       throw new Exception("Jeff and Beca are confused);
    }
}