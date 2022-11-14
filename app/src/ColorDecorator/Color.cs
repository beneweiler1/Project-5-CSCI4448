public abstract class Color
{
    public abstract string Assemble();
}

public class ConcreteColor : Color
{
    public override string Assemble()
    {
        return "Color: ";
    }
}
