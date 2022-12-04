//shape object contains 3D shape type, color, and animation
public abstract class Shape 
{
    AnimationRenderer _animation = new AnimationRenderer(); //animation strategy pattern
    Color _color = new ConcreteColor(); //color with decorator pattern
    public abstract void makeShape(int speed); //sets

    public void setRedColor()
    {
        this._color = new RedColor(this._color);
    }

    public void setBlueColor()
    {
        this._color = new BlueColor(this._color);
    }

    public void setGreenColor()
    {
        this._color = new GreenColor(this._color);
    }

    public void setAnimation(IAnimation animation)
    {
        this._animation.setAnimation(animation);
    }

    public String getColor(){
        return this._color.Assemble();
    }

    public string getAnimation(int speed){
        return this._animation.executeAnimation(speed);
    }

}

class Cube : Shape
{
    public override void makeShape(int speed)
    {
        //Console.WriteLine(this);
        Console.WriteLine("Shape Cube");
        Console.WriteLine(getColor());
        Console.WriteLine(getAnimation(speed));
        //possible unity code
        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube)
    }

}

class Capsule : Shape
{
        public override void makeShape(int speed)
    {
        Console.WriteLine("Shape Capsule");
        Console.WriteLine(getColor());
        Console.WriteLine(getAnimation(speed));
        //GameObject Capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
    }
}

class Sphere: Shape
{
        public override void makeShape(int speed)
    {
        Console.WriteLine("Shape Sphere");
        Console.WriteLine(getColor());
        Console.WriteLine(getAnimation(speed));
        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }
}

class Cylinder: Shape
{
        public override void makeShape(int speed)
    {
        Console.WriteLine("Shape Cylinder");
        Console.WriteLine(getColor());
        Console.WriteLine(getAnimation(speed));
        //GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    }
}

class Quad: Shape
{
        public override void makeShape(int speed)
    {
        Console.WriteLine("Shape Quad");
        Console.WriteLine(getColor());
        Console.WriteLine(getAnimation(speed));
        //GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
    }
}

class Plane: Shape
{
        public override void makeShape(int speed)
    {
        Console.WriteLine("Shape Plane");
        Console.WriteLine(getColor());
        Console.WriteLine(getAnimation(speed));
        //GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
    }
}