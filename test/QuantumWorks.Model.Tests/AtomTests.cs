using QuantumWorks.Model.CompositeParticles;

namespace QuantumWorks.Model.Tests;

public class AtomTests
{
    [Fact]
    public void MassNumber_Should_BeEqualToTheTotalNumberOfParticlesInTheNucleus()
    {
        // Arrange
        var hydrogen = new Atom
        {
            Nucleus = new List<ICompositeParticle> { new Proton() },
            Electrons = new List<Electron> { new Electron() }
        };
        
        var deuterium = new Atom
        {
            Nucleus = new List<ICompositeParticle> { new Proton(), new Neutron() },
            Electrons = new List<Electron> { new Electron() }
        };
        
        var tritium = new Atom
        {
            Nucleus = new List<ICompositeParticle> { new Proton(), new Neutron(), new Neutron() },
            Electrons = new List<Electron> { new Electron() }
        };
        
        // Act & Assert
        Assert.Equal(1, hydrogen.MassNumber);
        Assert.Equal(2, deuterium.MassNumber);
        Assert.Equal(3, tritium.MassNumber);
    }
    
    [Fact]
    public void AtomicNumber_Should_BeEqualToNumberOfProtonsInNucleus()
    {
        // Arrange
        var hydrogen = new Atom
        {
            Nucleus = new List<ICompositeParticle> { new Proton() },
            Electrons = new List<Electron> { new Electron() }
        };
        
        var deuterium = new Atom
        {
            Nucleus = new List<ICompositeParticle> { new Proton(), new Neutron() },
            Electrons = new List<Electron> { new Electron() }
        };
        
        var tritium = new Atom
        {
            Nucleus = new List<ICompositeParticle> { new Proton(), new Neutron(), new Neutron() },
            Electrons = new List<Electron> { new Electron() }
        };
        
        // Act & Assert
        Assert.Equal(1, hydrogen.AtomicNumber);
        Assert.Equal(1, deuterium.AtomicNumber);
        Assert.Equal(1, tritium.AtomicNumber);
    }
}