namespace QuantumWorks.Model;

public class QuarkCharm : IQuark
{
    public int MatterGeneration => 2;
    
    public string Flavor => "Charm";
    
    public double Charge => 2.0 / 3.0;
    public double Spin => 1.0 / 2.0;
}