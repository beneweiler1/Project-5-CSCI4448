// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
ShapeFactory factory = new ShapeFactory();

 Shape A = factory.FactoryMethod("A");
 A.draw(10);

 Shape B = factory.FactoryMethod("B");
 B.draw(20);

 //Console.ReadKey();