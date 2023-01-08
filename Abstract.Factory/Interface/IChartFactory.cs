namespace Abstract.Factory.Interface;

public interface IChartFactory
{
    IChart CreateChart(string type);
}