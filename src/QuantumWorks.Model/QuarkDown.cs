namespace QuantumWorks.Model;

public class QuarkDown : IQuark
{
    public int MatterGeneration => 1;
    
    public string Flavor => "Down";
    
    public double Charge => -1.0 / 3.0;
    public double Spin => 1.0 / 2.0;
}