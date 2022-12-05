
//https://www.tutorialspoint.com/design_pattern/decorator_pattern.htm

//Decorator Pattern for color
//Blueprint of color that decorator will use
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
