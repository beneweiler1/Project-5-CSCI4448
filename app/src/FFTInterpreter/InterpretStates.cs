//https://medium.com/net-core/how-to-manage-states-with-state-design-pattern-in-c-d4ca47ec6aa

//State pattern concept but does not have a class for each state option
//instead there are fucntions to interpret the FFT values
//FFT values are passed and the states of shape, color and animiation are changes
//generateShape method uses the passed factory to return a shape
public class InterpretStates:FFTInterpreter
{
    private string _shape;
    private string _color;
    private string _animation;

    public InterpretStates()
    {
        _shape = null;
        _color = null;
        _animation = null;
    }

    public void setStates(double low, double mid, double high) {
        _shape = interpretShape(high);
        _animation = interpretAnimation(mid);
        _color = colorInterpreter(low);
    }

    public Shape generateShape(Factory factory)
    {
       return factory.FactoryMethod(_shape,_animation,_color);
    }  
    public string interpretShape(double high)
    {
        if(high <= 0.5)
        {
            return "Cylinder";
        }
        else if(high <= 1.0)
        {
            return "Capsule";
        }
        else if(high <= 1.5)
        {
            return "Sphere";
        }
        else if(high <= 2.0)
        {
            return "Quad";
        }
        else if (high <= 2.5)
        {
            return "Cube";
        }
        return "Cube";
    }

//takes mid FFT and interprets it to a animation string
    public string interpretAnimation(double mid)
    {
        if(mid <= .05)
        {
            return "TopSpin";
        }
        else if(mid <= .1)
        {
            return "BackSpin";
        }
        else if(mid <= .15)
        {
            return "RightSpin";
        }
        else if (mid <= .2)
        {
            return "LeftSpin";
        }
        return "LeftSpin";
    }

//takes low FFT and interprets it to a color string
    public string colorInterpreter(double low)
    {
        if(low <= 0.1){
            return "Green";
        }
        else if(low <= 0.15){
            return "Blue";
        }
        else if (low <= 0.2)
        {
            return "Red";
        }
        return "Red";
    }

}