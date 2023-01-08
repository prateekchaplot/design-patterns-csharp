using Abstract.Factory.Charts.Abstract;

namespace Abstract.Factory.Charts.ThreeDimensionalCharts;

public class ThreeDimensionalBarChart : BarChart
{
    public override void Draw()
    {
        Console.WriteLine("[ThreeDimensionalBarChart: Draw]");
    }
}