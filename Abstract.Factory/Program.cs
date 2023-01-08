using Abstract.Factory.Factory;
using Abstract.Factory.Interface;

// get user input for the type of chart to create
string chartType = "bar";

// get user input for the chart "family" to use
string chartFamily = "3D";

IChartFactory chartFactory;
switch (chartFamily)
{
    case "2D":
        chartFactory = new TwoDimensionalChartFactory();
        break;
    
    case "3D":
        chartFactory = new ThreeDimensionalChartFactory();
        break;

    default:
        throw new Exception("Invalid chart family");
}
    

IChart chart = chartFactory.CreateChart(chartType);
chart.Draw();