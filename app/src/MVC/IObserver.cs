//observer interface (used by fft view)
//pattern: observer/subsriber
public interface Observer {
    public void update(double high, double mid, double low);
}