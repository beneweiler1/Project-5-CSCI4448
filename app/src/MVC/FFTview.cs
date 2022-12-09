using System;
public class FFTview : Observer {
    private FFTmodel model;
    private ControllerInterface controller;
    private double high;
    private double mid;
    private double low;
    //possible components for displays

    public FFTview(ControllerInterface controller, FFTmodel model) {
        this.controller = controller;
        this.model = model;
        model.registerObserver(this);
        this.Prompt();
    }

   
    public void update(double high, double mid, double low) {
        this.low = low;
        this.high = high;
        this.mid = mid;
        //add state
        Console.WriteLine("view: " + low + "," + mid + "," + high + " from the view");
    }

    public void Prompt() {
        Console.WriteLine("Welcome to Audio Visualizer");
        //setting bpm
        bool valid = false;
        while (!valid) {
            Console.WriteLine("Set a bpm");
            string bpm = Console.ReadLine();
            try {
                controller.setBPM(Convert.ToInt16(bpm));
                valid = true;
            }
            catch (Exception e) {
                Console.WriteLine("Error: " + bpm + " is not a valid number");
            }
        }
        Console.WriteLine("Controls:");
        Console.WriteLine("Controls: press [p] to play");
        string option = Console.ReadLine();
        if (option == "p") {
            controller.start();
        }
    }

    // add any code for user interface controls

}