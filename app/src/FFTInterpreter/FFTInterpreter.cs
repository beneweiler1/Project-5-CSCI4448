
//state pattern but not identical due to the amount of states

interface FFTInterpreter
{    
    Shape generateShape(Factory factory);
    void setStates(double low, double mid, double high);
}