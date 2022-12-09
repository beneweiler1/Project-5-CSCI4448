//interface for model
public interface FFTmodelInterface {

    public void initialize();
    public void readExcelfile();
    public void on();
    public void off();
    
    public void setFFTvalues(double low, double high, double mid);

    public void registerObserver(FFTview o);

    // pattern: observer/subsriber
    public void removeObserver(FFTview o);

    public void notifyFFTObserver();

    public void setBPM(int bpm);
    public void setFilename(string filename);

    // public void registerObserver(BPMObserver o);

    // public void removeObserver(BPMObserver o);

}