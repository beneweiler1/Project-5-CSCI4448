//Decorator Pattern for color

public class ColorDecorator : Color
{
    protected Color _color;

    public ColorDecorator(Color color) {
        {
            this._color = color;
        }
    }
    
    public void SetColor(Color color)
    {
        this._color = color;
    }

    public override string Assemble()
    {
        return this._color.Assemble();
    }
}
