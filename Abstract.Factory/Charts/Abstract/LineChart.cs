using Abstract.Factory.Interface;

namespace Abstract.Factory.Charts.Abstract;

public abstract class LineChart : IChart
{
    public abstract void Draw();
}