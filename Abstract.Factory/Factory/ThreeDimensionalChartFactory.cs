using Abstract.Factory.Charts.ThreeDimensionalCharts;
using Abstract.Factory.Interface;

namespace Abstract.Factory.Factory;

public class ThreeDimensionalChartFactory : IChartFactory
{
    public IChart CreateChart(string type)
    {
        IChart chart;

        switch (type)
        {
            case "bar":
                chart = new ThreeDimensionalBarChart();
                break;

            case "line":
                chart = new ThreeDimensionalLineChart();
                break;

            case "pie":
                chart = new ThreeDimensionalPieChart();
                break;

            default:
                throw new Exception("Invalid chart type");
        }

        return chart;
    }
}