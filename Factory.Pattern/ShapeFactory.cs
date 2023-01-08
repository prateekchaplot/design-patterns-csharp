using Factory.Pattern.Shapes;

namespace Factory.Pattern;

public class ShapeFactory
{
    public IShape CreateShape(string type)
    {
        IShape shape;
        switch (type)
        {
            case "circle":
                shape = new Circle();
                break;
            
            case "triangle":
                shape = new Triangle();
                break;
            
            case "square":
                shape = new Square();
                break;

            default:
                throw new Exception("Invalid shape type");
        }

        return shape;
    }
}