using QuantumWorks.Model.CompositeParticles;

namespace QuantumWorks.Model.Tests;

public class Atom
{
    public IEnumerable<ICompositeParticle> Nucleus { get; set; }
    
    public IEnumerable<Electron> Electrons { get; set; }

    public int MassNumber => Nucleus.Count();
    
    public int AtomicNumber => Nucleus.Count(p => p is Proton);
}