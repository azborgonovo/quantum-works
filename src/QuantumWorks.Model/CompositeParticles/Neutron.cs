namespace QuantumWorks.Model.CompositeParticles;

public class Neutron : ICompositeParticle
{
    public IEnumerable<IParticle> Components => new IQuark[]
    {
        // According to the Standard Model, a neutron is made of one up quark and two down quarks.
        new QuarkUp(),
        new QuarkDown(),
        new QuarkDown(),
    };
}