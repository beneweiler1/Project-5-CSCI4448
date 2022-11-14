public abstract class Shape 
{

    string _animation = "";
    string _color = "";
    public abstract void draw(int test);

    public void setColor(string color)
    {
        this._color = color;
    }

    public void setAnimation(string animation)
    {
        this._animation = animation;
    }

    public string getColor(){
        return this._color;
    }

      public string getAnimation(){
        return this._animation;
    }

}

class Cube : Shape
{
    public override void draw(int test)
    {
        Console.WriteLine("Shape A : " + test.ToString());
        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

}

class Capsule : Shape
{
        public override void draw(int test)
    {
        Console.WriteLine("Shape B : " + test.ToString());
        //GameObject Capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
    }
}

class Sphere: Shape
{
        public override void draw(int test)
    {
        Console.WriteLine("Shape B : " + test.ToString());
        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }
}

class Cylinder: Shape
{
        public override void draw(int test)
    {
        Console.WriteLine("Shape B : " + test.ToString());
        //GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    }
}

class Quad: Shape
{
        public override void draw(int test)
    {
        Console.WriteLine("Shape B : " + test.ToString());
        //GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
    }
}

class Plane: Shape
{
        public override void draw(int test)
    {
        Console.WriteLine("Shape B : " + test.ToString());
        //GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
    }
}