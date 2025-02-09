namespace QuantumWorks.Model;

/// <summary>
/// Defines the properties of a matter particle (also called fermion).
/// </summary>
public interface IMatterParticle : IParticle
{
    public int MatterGeneration { get; }
}