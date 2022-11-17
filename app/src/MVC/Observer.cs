public interface Observer {
    public void update(int high, int mid, int low);
}

public class FFTObserver : Observer {
    protected int high;
    protected int mid;
    protected int low;
    public void update(int high, int mid, int low) {
        this.low = low;
        this.high = high;
        this.mid = mid;
    }
}