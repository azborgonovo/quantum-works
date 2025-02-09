namespace QuantumWorks.Model;

public class QuarkStrange : IQuark
{
    public int MatterGeneration => 2;
    
    public string Flavor => "Strange";
    
    public double Charge => -1.0 / 3.0;
    public double Spin => 1.0 / 2.0;
}