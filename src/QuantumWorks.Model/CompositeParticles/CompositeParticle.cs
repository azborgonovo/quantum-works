namespace QuantumWorks.Model.CompositeParticles;

public interface ICompositeParticle
{
    public IEnumerable<IParticle> Components { get; }

    public double TotalCharge => Components.Sum(component => component.Charge);
}