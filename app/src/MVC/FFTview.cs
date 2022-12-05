public class FFTview : FFTObserver {
    private FFTmodel model;
    FFTcontroller controller;

    public FFTview(FFTmodel model) {
        this.model = model;
        this.controller = controller;
        model.registerObserver(this);
    }
    void updateFFT() {
<<<<<<< HEAD
        int low = model.getLow();
        int high = model.getHigh();
        int mid = model.getMid();
        Console.WriteLine(low + "," + high + "," + mid);
        //interpreter
=======
        double low = model.getLow();
        double high = model.getHigh();
        double mid = model.getMid();
        Console.WriteLine(low + "," + mid + "," + high);
>>>>>>> db3b67a0980b256e1407681d8a02f1cdcbf2815a
    }

}