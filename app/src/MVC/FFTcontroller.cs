
//MVC pattern : controller
public class FFTcontroller : ControllerInterface {
    private FFTmodel model;
    private FFTview view;

    // sets model and creates view
    public FFTcontroller(FFTmodel model) {
        this.model = model;
        model.initialize();
        view = new FFTview(this, model);
        //TODO add all view initializing
        // view.disableStopMenuItem();
        // view.enableStartMenuItem();
        
    }

    // invokes the model to turn on
    public void start() {
        model.on();
        // view.disableStartMenuItem();
        // view.enableStopMenuItem();
    }

    // invokes the model to turn off
    public void stop() {
        model.off();
        // view.disableStopMenuItem();
        // view.enableStartMenuItem();
    }
    
    // sets the bpm in the model
    public void setBPM(int bpm) {
        model.setBPM(bpm);
    }

    // set the filename of the model
    public void setFilename(string filename) {
        model.setFilename(filename);
    }
}