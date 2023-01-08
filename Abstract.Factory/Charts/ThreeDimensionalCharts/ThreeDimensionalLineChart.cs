using Abstract.Factory.Charts.Abstract;

namespace Abstract.Factory.Charts.ThreeDimensionalCharts;

public class ThreeDimensionalLineChart : LineChart
{
    public override void Draw()
    {
        Console.WriteLine("[ThreeDimensionalLineChart: Draw]");
    }
}