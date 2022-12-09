// See https://aka.ms/new-console-template for more information



InterpretStates interpretStates = new InterpretStates();
ShapeFactory factory = new ShapeFactory();
interpretStates.setStates(1,2,1);
Shape shape = interpretStates.generateShape(factory);
//shape.makeShape(10);


 FFTmodel model = new FFTmodel();
 ControllerInterface controller = new FFTcontroller(model);


interpretStates.setStates(model.getLow(), model.getMid(), model.getHigh());
Shape shapeNew = interpretStates.generateShape(factory);
shapeNew.makeShape(10);

