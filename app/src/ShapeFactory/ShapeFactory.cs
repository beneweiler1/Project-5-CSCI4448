class ShapeFactory : Factory
{
 public override Shape FactoryMethod(string type)
 {
 switch (type)
 {
 case "A": return new Cube();
 case "B": return new Cylinder();
 default: throw new ArgumentException("Invalid type", "type");
 }
 }
}