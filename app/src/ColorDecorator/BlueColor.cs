public class BlueColor : ColorDecorator
{
    public BlueColor(Color color) : base(color)
    {
    }

    public override string Assemble()
    {
        return base.Assemble() + "BlueColor";
    }
}