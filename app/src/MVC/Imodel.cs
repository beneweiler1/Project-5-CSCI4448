//interface for model
public interface FFTmodelInterface {

    void initialize();
    void readExcelfile();
    void on();
    void off();

    double getMid();

    double getHigh();

    double getLow();
    
    void setFFTvalues(double low, double high, double mid);

    void registerObserver(FFTview o);

    // pattern: observer/subsriber
    void removeObserver(FFTview o);

    void notifyFFTObserver();

    public void setBPM(int bpm);
    public void setFilename(string filename);

    // public void registerObserver(BPMObserver o);

    // public void removeObserver(BPMObserver o);

}