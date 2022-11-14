class RedColor : ColorDecorator
{
    public RedColor(Color color) : base(color)
    {
    }
    public override string Assemble()
    {
        return base.Assemble() + "RedColor";
    }
}