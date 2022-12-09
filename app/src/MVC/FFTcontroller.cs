public interface ControllerInterface {
    public void start();
    public void stop();
    // public void setFFTvalues(int high, int mid, int low);
    public void setBPM(int bpm);
    public void setFilename(string filename);
}

public class FFTcontroller : ControllerInterface {
    private FFTmodel model;
    private FFTview view;
    public FFTcontroller(FFTmodel model) {
        this.model = model;
        model.initialize();
        view = new FFTview(this, model);
        //TODO add all view initializing
        // view.disableStopMenuItem();
        // view.enableStartMenuItem();
        
    }

    public void start() {
        model.on();
        // view.disableStartMenuItem();
        // view.enableStopMenuItem();
    }

    public void stop() {
        model.off();
        // view.disableStopMenuItem();
        // view.enableStartMenuItem();
    }
    
    public void setBPM(int bpm) {
        model.setBPM(bpm);
    }
    public void setFilename(string filename) {
        model.setFilename(filename);
    }
    // public void setFFTvalues(int high, int mid, int low) {
    //     model.setFFTvalues(high, mid, low);
    // }
}