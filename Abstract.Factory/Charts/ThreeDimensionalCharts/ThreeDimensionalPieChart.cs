using Abstract.Factory.Charts.Abstract;

namespace Abstract.Factory.Charts.ThreeDimensionalCharts;

public class ThreeDimensionalPieChart : PieChart
{
    public override void Draw()
    {
        Console.WriteLine("[ThreeDimensionalPieChart: Draw]");
    }
}