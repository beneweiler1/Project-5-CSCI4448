//https://www.tutorialspoint.com/design_pattern/factory_pattern.htm
//Factory to create Shapes
class ShapeFactory : Factory
{
    // singleton in csharp
    // https://csharpindepth.com/articles/singleton
    private static readonly ShapeFactory instance = new ShapeFactory();
    static ShapeFactory() { }
    private ShapeFactory() { }

    public static ShapeFactory getInstance() { 
        return instance;
    }
 public override Shape FactoryMethod(string shape, string animation, string color)
 {
    Shape _shape;

 switch (shape)
{
    case "Cylinder": _shape = new Cylinder();
    break;
    case "Capsule": _shape = new Capsule();
    break;
    case "Sphere": _shape = new Sphere();
    break;
    case "Cube": _shape = new Cube();
    break;
 default: throw new ArgumentException("Invalid type");
 }

switch (color)
 {
    case "Green": _shape.setGreenColor();
        break;
    case "Blue": _shape.setBlueColor();
        break;
    case "Red": _shape.setRedColor();
        break;
 default: throw new ArgumentException("Invalid type");
 }

switch (animation)
 {
    case "TopSpin": _shape.setAnimation(new TopSpin());
        break;
    case "BackSpin": _shape.setAnimation(new BackSpin());
        break;
    case "RightSpin": _shape.setAnimation(new RightSpin());
        break;
    case "LeftSpin": _shape.setAnimation(new LeftSpin());
        break;
    default: throw new ArgumentException("Invalid type");
 }
 return _shape;
 
 }
}