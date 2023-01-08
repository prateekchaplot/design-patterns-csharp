using Abstract.Factory.Charts.Abstract;

namespace Abstract.Factory.Charts.TwoDimensionalCharts;

public class TwoDimensionalBarChart : BarChart
{
    public override void Draw()
    {
        Console.WriteLine("[TwoDimensionalBarChart: Draw]");
    }
}