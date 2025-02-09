namespace QuantumWorks.Model;

public class Electron : ILepton
{
    public int MatterGeneration => 1;
    
    public double Charge => -1;
    public double Spin => 1.0 / 2.0;
}