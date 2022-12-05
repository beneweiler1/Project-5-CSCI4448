
//https://www.tutorialspoint.com/design_pattern/strategy_pattern.htm

//Animation Renderer using strategy pattern
public class AnimationRenderer
{
    private IAnimation _animation;

    public AnimationRenderer(){} //empty animation for init

    public void setAnimation(IAnimation animation) //changes animation
    {
        this._animation = animation;
    }

    public string executeAnimation(int speed) //adds animation speed
    {
        return _animation.Animation(speed);
    }

}

