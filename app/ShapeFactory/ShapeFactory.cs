class ShapeFactory : Factory
{
 public override Shape FactoryMethod(string type)
 {
 switch (type)
 {
 case "A": return new ConcreteShapeA();
 case "B": return new ConcreteShapeB();
 default: throw new ArgumentException("Invalid type", "type");
 }
 }
}