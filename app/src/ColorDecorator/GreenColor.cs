class GreenColor : ColorDecorator
{
    public GreenColor(Color color) : base(color)
    {
    }
    public override string Assemble()
    {
        return base.Assemble() + "GreenColor";
    }
}