public class Context
{
    private IAnimation _animation;

    public Context(){}

    public Context(IAnimation animation)
    {
        this._animation = animation;
    }

    public void setStrategy(IAnimation animation)
    {
        this._animation = animation;
    }

    public string executeStrategy(int speed)
    {
        return _animation.Animation(speed);
    }

}

