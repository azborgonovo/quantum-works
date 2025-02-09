namespace QuantumWorks.Model;

public class QuarkTop : IQuark
{
    public int MatterGeneration => 3;
    
    public string Flavor => "Top";
    
    public double Charge => 2.0 / 3.0;
    public double Spin => 1.0 / 2.0;
}