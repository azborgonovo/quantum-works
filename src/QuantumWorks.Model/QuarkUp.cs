namespace QuantumWorks.Model;

public class QuarkUp : IQuark
{
    public int MatterGeneration => 1;
    
    public string Flavor => "Up";
    
    public double Charge => 2.0 / 3.0;
    public double Spin => 1.0 / 2.0;
}