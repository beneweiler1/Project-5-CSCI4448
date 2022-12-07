public class FFTview : FFTObserver {
    private FFTmodel model;
    private ControllerInterface controller;
    //possible components for displays

    public FFTview(ControllerInterface controller, FFTmodel model) {
        this.controller = controller;
        this.model = model;
        model.registerObserver(this);
    }
    void updateFFT() {
        double low = model.getLow();
        double high = model.getHigh();
        double mid = model.getMid();
        Console.WriteLine(low + "," + mid + "," + high + " from the view");
    }

    // add any code for user interface controls

}