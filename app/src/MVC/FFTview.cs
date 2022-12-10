using System;
//MVC pattern : view
public class FFTview : Observer {
    private FFTmodel model;
    private ControllerInterface controller;
    // fft values
    private double high;
    private double mid;
    private double low;
    // state interpreter for factory methods
    private InterpretStates fftInterpreter;
    //possible components for displays

    // Constructor
    // must take in a model and controller
    public FFTview(ControllerInterface controller, FFTmodel model) {
        this.fftInterpreter = new InterpretStates();
        this.controller = controller;
        this.model = model;
        model.registerObserver(this);
        this.Prompt();
    }

   // updates the fft values and sends them to the state and factory patterns
    public void update(double high, double mid, double low) {
        this.low = low;
        this.high = high;
        this.mid = mid;
        //add state
        
        fftInterpreter.setStates(low, mid, high);
        ShapeFactory factory = ShapeFactory.getInstance();
        Shape shape = fftInterpreter.generateShape(ShapeFactory.getInstance()); //singleton
        shape.makeShape(10);
        Console.WriteLine("view: " + low + "," + mid + "," + high );
    }

    //prompts the user for inputs
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
        valid = false;
        while (!valid) {
            Console.WriteLine("Select song [1]/[2]");
            string choice = Console.ReadLine();
            if (choice == "1") {
                controller.setFilename("Song1.csv");
                valid = true;
            } else if (choice == "2") {
                controller.setFilename("test.csv");
                valid = true;
            }
        }
        Console.WriteLine("Controls:");
        Console.WriteLine("Controls: press [p] to play");
        string option = Console.ReadLine();
        if (option == "p") {
            controller.start();
        }
    }

}