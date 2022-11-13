 class Test
 {
 static void Main(string[] args)
 {
ShapeFactory factory = new ShapeFactory();

 Shape A = factory.FactoryMethod("A");
 A.draw(10);

 Shape B = factory.FactoryMethod("B");
 B.draw(20);

 Console.ReadKey();

 }
}