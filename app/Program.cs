// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//  Shape B = factory.FactoryMethod("B");
//  B.draw(20);

// void setStrategy(IAnimation strat)
// {
//     _animation = strat;
// }
InterpretStates interpretStates = new InterpretStates();
ShapeFactory factory = new ShapeFactory();
interpretStates.setStates(1,2,1);
Shape shape = interpretStates.generateShape(factory);
shape.makeShape(10);

// Shape A = factory.FactoryMethod("Cube", "BackSpin", "Red");
// A.makeShape(10);
// Console.WriteLine(A.getColor());
// Console.WriteLine(A.getAnimation(10));

//  var animationRenderer = new AnimationRenderer();


//  IAnimation spin = new BackSpin();
//   animationRenderer.setStrategy(spin);
//   Console.WriteLine(animationRenderer.executeStrategy(10));

//   var color = new ConcreteColor();
//   RedColor red = new RedColor(color);
  //Console.WriteLine(red.Assemble());
  //BlueColor blue = new BlueColor(red);

 //top.CallAnimation(10);

 //Console.ReadKey();