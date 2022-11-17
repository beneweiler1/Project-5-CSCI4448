
public interface FFTmodelInterface {
    void readExcelfile(string filename);

    int getMid();

    int getHigh();

    int getLow();
    
    void setFFTvalues(int low, int high, int mid);

    void registerObserver(FFTObserver o);

    void removeObserver(FFTObserver o);

    void notifyFFTObserver();


    // public int getBPM();

    // public void setBPM(int bpm);

    // public void registerObserver(BPMObserver o);

    // public void removeObserver(BPMObserver o);

}

public class FFTmodel : FFTmodelInterface {

    private List<FFTObserver> FFTlst = new List<FFTObserver>();
    // ArrayList BPMlst = new ArrayList();

    private int bpm = 90; //default
    private int low;
    private int mid;
    private int high;

    public void readExcelfile(string filename) {
        //try opening excel file and gathering data
    }

    public int getMid() {
        return this.mid;
    }

    public int getHigh() {
        return this.high;
    }

    public int getLow() {
        return this.low;
    }

    public void setFFTvalues(int low, int high, int mid) {
        this.low = low;
        this.high = high;
        this.mid = mid;
        notifyFFTObserver();
    }

    public void registerObserver(FFTObserver o) {
        FFTlst.Add(o);
    }

    public void removeObserver(FFTObserver o) {
        FFTlst.Remove(o);
    }

    public void notifyFFTObserver() {
        if (FFTlst.Count > 0) {
            for (int i = 0; i < FFTlst.Count; i++) {
                FFTlst[i].update(this.high, this.mid, this.low);
            }
        }
    }

    // public int getBPM() {
    //     return this.bpm;
    // }

    // public void setBPM(int bpm){
    //     this.bpm = bpm;
    //     // notifyBPMObserver();
    // } 

    // void registerObserver(BPMObserver o) {
    //     BPMlst.Add(o);
    // }

    // void removeObserver(BPMObserver o) {
    //     BPMlst.Remove(o);
    // }

    // public void notifyBPMObserver() {
    //     for (int i = 0; i < BPMlst.Count; i++) {
    //         BPMlst[i].update(this.bpm);
    //     }
    // }
}