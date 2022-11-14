// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
ShapeFactory factory = new ShapeFactory();

 Shape A = factory.FactoryMethod("A");
 A.draw(10);

 Shape B = factory.FactoryMethod("B");
 B.draw(20);

// void setStrategy(IAnimation strat)
// {
//     _animation = strat;
// }

  var context = new Context();

  context.setStrategy(new BackSpin());
  Console.WriteLine(context.executeStrategy(10));


  var color = new ConcreteColor();
  RedColor red = new RedColor(color);
  Console.WriteLine(red.Assemble());
  //BlueColor blue = new BlueColor(red);

 //top.CallAnimation(10);

 //Console.ReadKey();