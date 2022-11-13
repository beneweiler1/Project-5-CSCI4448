public interface Shape {
    void draw(int test);
}

class ConcreteShapeA : Shape
{
    public void draw(int test)
    {
        Console.WriteLine("Shape A : " + test.ToString());
    }
}

class ConcreteShapeB : Shape
{
        public void draw(int test)
    {
        Console.WriteLine("Shape B : " + test.ToString());
    }
}