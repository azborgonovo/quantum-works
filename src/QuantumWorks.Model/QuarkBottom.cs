namespace QuantumWorks.Model;

public class QuarkBottom : IQuark
{
    public int MatterGeneration => 3;
    
    public string Flavor => "Bottom";
    
    public double Charge => -1.0 / 3.0;
    public double Spin => 1.0 / 2.0;
}