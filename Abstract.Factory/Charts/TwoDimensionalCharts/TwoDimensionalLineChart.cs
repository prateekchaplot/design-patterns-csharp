using Abstract.Factory.Charts.Abstract;

namespace Abstract.Factory.Charts.TwoDimensionalCharts;

public class TwoDimensionalLineChart : LineChart
{
    public override void Draw()
    {
        Console.WriteLine("[TwoDimensionalLineChart: Draw]");
    }
}