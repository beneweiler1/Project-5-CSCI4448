using System.IO;

public interface FFTmodelInterface {
    void readExcelfile(string filename);

    double getMid();

    double getHigh();

    double getLow();
    
    void setFFTvalues(double low, double high, double mid);

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

    private double bpm = 90; //default
    private double low;
    private double mid;
    private double high;

    public void readExcelfile(string filename) {
        //try opening excel file and gathering data
        // https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
        // https://stackoverflow.com/questions/15560011/how-to-read-a-csv-file-one-line-at-a-time-and-parse-out-keywords
        using(StreamReader reader = new StreamReader(@"db/" + filename + ".csv")) {
            string line;
            line = reader.ReadLine(); // read first line
            while ((line = reader.ReadLine()) != null) {
                var values = line.Split(',');
                this.low = Convert.ToDouble(values[0]);
                // this.low = Double.TryParse(values[0], System.Globalization.NumberStyles.Float, out this.low);
                this.mid =Convert.ToDouble(values[1]);
                this.high =Convert.ToDouble(values[0]);
                //Console.WriteLine(this.low + "," + this.mid + "," + this.high); 
            }
        }
    }

    public double getMid() {
        return this.mid;
    }

    public double getHigh() {
        return this.high;
    }

    public double getLow() {
        return this.low;
    }

    public void setFFTvalues(double low, double high, double mid) {
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