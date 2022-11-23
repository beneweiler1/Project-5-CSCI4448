public class FFTview : FFTObserver {
    private FFTmodel model;
    FFTcontroller controller;

    public FFTview(FFTmodel model) {
        this.model = model;
        this.controller = controller;
        model.registerObserver(this);
    }
    void updateFFT() {
        int low = model.getLow();
        int high = model.getHigh();
        int mid = model.getMid();
        Console.WriteLine(low + "," + high + "," + mid);
    }

}