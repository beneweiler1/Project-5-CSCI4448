using System.IO;
using System.Threading;
using System.Collections.Generic;

//MVC pattern : model
public class FFTmodel : FFTmodelInterface {

    private List<FFTview> FFTlst = new List<FFTview>();
    //beat thread
    private Thread thread; // https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread?view=net-7.0
    private Boolean stop = false; // starts and stops beat thread
    private double bpm = 100; //default tells how long the thread should wait

    private List<double[]> FFTBufferArray = new List<double[]>(); // contains fft values from .csv files, used in initialize
    int index; // index for FFTBufferArray
    string filename = "test.csv"; // file name for fft values, test by defualt
    // fft values
    private double low;
    private double mid;
    private double high;

    // tries to open file and clears any values in FFTBufferArray
    public void initialize() {
        this.FFTBufferArray = new List<double[]>();
        try {
            readExcelfile();
        }
        catch (FileNotFoundException e) {
            Console.WriteLine("File: " + filename + " not found", e);
        }
    }

    // reads excel file and adds to FFTBufferArray
    public void readExcelfile() {
        //try opening excel file and gathering data
        // https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
        // https://stackoverflow.com/questions/15560011/how-to-read-a-csv-file-one-line-at-a-time-and-parse-out-keywords
        using(StreamReader reader = new StreamReader(@"db/" + this.filename)) {
            Console.WriteLine("loading FFT values from " + filename);
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
            }
        }
    }
    //function for thread to process
    // updates the fft values using the FFTbufferArray 
    // frequency of updates depends on bpm
    public void ThreadProc() {
        if (FFTBufferArray != null) {
            while (index < FFTBufferArray.Count && !stop) {
                double[] FFTvalues = FFTBufferArray[index];
                this.setFFTvalues(FFTvalues[2], FFTvalues[1], FFTvalues[0]);
                double sleep = 60000/bpm;
                this.index ++;
                // Console.WriteLine(FFTvalues[0] + ", " + FFTvalues[1] + ", " +  FFTvalues[2]);
                Thread.Sleep((int)sleep);
            }
        }
        else {
            Console.WriteLine("Error: FFTBufferArray is empty");
        }
    }
    
    // resets fft values and index as well as starts the model
    public void on() {
        //set default values
        this.low = 0; 
        this.mid = 0;
        this.high = 0;
        this.index = 0;
        this.start();
    } 

    // starts the thread
    public void start() {
        this.stop = false;
        thread = new Thread(new ThreadStart(ThreadProc));
        thread.Start();
    }

    // turns off the thread by changin stop value to true
    public void off() {
        //stop thread
        //print whats in 
        // foreach(double[] elm in FFTBufferArray) {
        //     Console.WriteLine(elm[0] + "," + elm[1]  + "," + elm[2]);
        // }
        stop = true;
    }

    // sets fft values and calsl notifyFFTObserver
    public void setFFTvalues(double high, double mid, double low) {
        this.low = low;
        this.high = high;
        this.mid = mid;
        notifyFFTObserver();
    }

    public void setBPM(int bpm) {
        this.bpm = bpm;
    }

    // sets filename and restarts model to use new file
    public void setFilename(string filename) {
        //switch songs and restart
        this.off();
        this.filename = filename;
        this.initialize();
        this.on();
    }

    // pattern: observer/subsriber
    public void registerObserver(FFTview o) {
        FFTlst.Add(o);
    }

    public void removeObserver(FFTview o) {
        FFTlst.Remove(o);
    }

    public void notifyFFTObserver() {
        // Console.WriteLine("notifying observers");
        // Console.WriteLine(FFTlst.Count());
        if (FFTlst.Count > 0) {
            for (int i = 0; i < FFTlst.Count; i++) {
                FFTlst[i].update(this.high, this.mid, this.low);
            }
        }
    }
}