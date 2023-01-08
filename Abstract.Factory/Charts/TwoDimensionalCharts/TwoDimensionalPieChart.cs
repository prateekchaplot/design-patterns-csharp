using Abstract.Factory.Charts.Abstract;

namespace Abstract.Factory.Charts.TwoDimensionalCharts;

public class TwoDimensionalPieChart : PieChart
{
    public override void Draw()
    {
        Console.WriteLine("[TwoDimensionalPieChart: Draw]");
    }
}