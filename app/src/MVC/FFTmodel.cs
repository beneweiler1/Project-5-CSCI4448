using System.IO;
using System.Threading;
using System.Collections.Generic;


public interface FFTmodelInterface {

    void initialize(string filename);
    void on();
    void off();
    void readExcelfile(string filename);

    double getMid();

    double getHigh();

    double getLow();
    
    void setFFTvalues(double low, double high, double mid);

    void registerObserver(FFTObserver o);

    void removeObserver(FFTObserver o);

    void notifyFFTObserver();


    // public int getBPM();

    public void setBPM(int bpm);

    // public void registerObserver(BPMObserver o);

    // public void removeObserver(BPMObserver o);

}

public class FFTmodel : FFTmodelInterface {

    private List<FFTObserver> FFTlst = new List<FFTObserver>();
    // ArrayList BPMlst = new ArrayList();
    Thread thread; // https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread?view=net-7.0
    //beat thread
    Boolean stop; // starts and stops beat thread
    private double bpm = 90; //default tells how long the thread should wait

    private List<double[]> FFTBufferArray;
    int index; 
    private double low;
    private double mid;
    private double high;
    public void initialize(string filename) {
        FFTBufferArray = new List<double[]>();
        try {
            readExcelfile(filename);
        }
        catch (FileNotFoundException e) {
            Console.WriteLine("File: " + filename + " not found", e);
        }
    }
    //TODO
    public void ThreadProc() {
        while (index < FFTBufferArray.Count && !stop) {
            double[] FFTvalues = FFTBufferArray[index];
            this.index ++;
            this.setFFTvalues(FFTvalues[0], FFTvalues[1], FFTvalues[2]);
            double sleep = 60000/bpm;
            Console.WriteLine(FFTvalues[0] + ", " + FFTvalues[1] + ", " +  FFTvalues[2]);
            Thread.Sleep((int)sleep);
        }
    }
    
    public void on() {
        //set default values
        this.low = 0; 
        this.mid = 0;
        this.high = 0;
        this.bpm = 90;
        this.index = 0;
        notifyFFTObserver();
        thread = new Thread(new ThreadStart(ThreadProc));
        stop = false;
        thread.Start();
    } 
    public void off() {
        //stop thread
        //print whats in 
        // foreach(double[] elm in FFTBufferArray) {
        //     Console.WriteLine(elm[0] + "," + elm[1]  + "," + elm[2]);
        // }
        stop = true;
    }
    public void readExcelfile(string filename) {
        //try opening excel file and gathering data
        // https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
        // https://stackoverflow.com/questions/15560011/how-to-read-a-csv-file-one-line-at-a-time-and-parse-out-keywords
        using(StreamReader reader = new StreamReader(@"db/" + filename + ".csv")) {
            Console.WriteLine("loading FFT values...");
            string line;
            line = reader.ReadLine(); // read first line
            while ((line = reader.ReadLine()) != null) {
                var values = line.Split(',');
                // this.low = Convert.ToDouble(values[0]);
                // this.mid =Convert.ToDouble(values[1]);
                double[] FFTvalues = new double[3];
                FFTvalues[0] = Convert.ToDouble(values[0]);
                FFTvalues[1] = Convert.ToDouble(values[1]);
                FFTvalues[2] = Convert.ToDouble(values[2]);
                FFTBufferArray.Add(FFTvalues); 
                // Console.WriteLine(this.low + "," + this.mid + "," + this.high); 
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

    public void setBPM(int bpm) {
        this.bpm = bpm;
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