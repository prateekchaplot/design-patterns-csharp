using Abstract.Factory.Charts.TwoDimensionalCharts;
using Abstract.Factory.Interface;

namespace Abstract.Factory.Factory;

public class TwoDimensionalChartFactory : IChartFactory
{
    public IChart CreateChart(string type)
    {
        IChart chart;

        switch (type)
        {
            case "bar":
                chart = new TwoDimensionalBarChart();
                break;

            case "line":
                chart = new TwoDimensionalLineChart();
                break;

            case "pie":
                chart = new TwoDimensionalPieChart();
                break;

            default:
                throw new Exception("Invalid chart type");
        }

        return chart;
    }
}