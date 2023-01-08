using Factory.Pattern;

var shapeFactory = new ShapeFactory();

// get user input for the type of shape to create
var types = new string[] { "circle", "triangle", "square" };
foreach (string type in types)
{
    var shape = shapeFactory.CreateShape(type);
    shape.Draw();
}
