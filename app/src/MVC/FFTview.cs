public class FFTview : FFTObserver {
    private FFTmodel model;
    FFTcontroller controller;


    public FFTview(FFTmodel model) {
        this.model = model;
        this.controller = controller;
        model.registerObserver(this);
    }
    void updateFFT() {
        double low = model.getLow();
        double high = model.getHigh();
        double mid = model.getMid();
        Console.WriteLine(low + "," + mid + "," + high);
        // fftInterpreter.setStates(low, mid, high);
        // Shape shape = fftInterpreter.generateShape(factory);
        // shape.makeShape(10);
        }

}