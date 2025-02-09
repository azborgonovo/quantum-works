namespace QuantumWorks.Model.CompositeParticles;

public class Proton : ICompositeParticle
{
    public IEnumerable<IParticle> Components => new IQuark[]
    {
        // According to the Standard Model, a proton is made of two up quarks and one down quark.
        new QuarkUp(),
        new QuarkUp(),
        new QuarkDown(),
    };
}