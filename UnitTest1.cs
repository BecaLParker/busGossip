
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
    
    [Test]
    public void WhenThreeDriversMeet_ShouldReturnNumberOfStops()
    {
        // arrange
        

        // act
        var result = Program.GetNumberOfStops(new List<int> { 4, 5, 3 }, new List<int> { 2, 1, 3 }, new List<int> { 1, 2, 3 });

        // assert
        Assert.That(result, Is.EqualTo(3));
    }
}

internal class Program
{
    internal static int GetNumberOfStops(params List <int>[] routes)
    {
        var holder = new List<List<int>>();
        
        for (int i = 0; i < 480; i++)
        {
            var stops = routes.Select(route => route[i % route.Count]).ToList();
            holder.Add(stops);
        }
        
        var meetingPlace = holder.FirstOrDefault(x => x.Distinct().Count() == 1);

        return holder.IndexOf(meetingPlace) + 1;
    }
}