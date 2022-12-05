public interface Observer {
    public void update(double high, double mid, double low);
}

public class FFTObserver : Observer {
    protected double high;
    protected double mid;
    protected double low;
    public void update(double high, double mid, double low) {
        this.low = low;
        this.high = high;
        this.mid = mid;
    }
}