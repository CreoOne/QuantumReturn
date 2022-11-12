using QuantumEvolve.Core.TerminationStrategy;

namespace QuantumEvolve.Core.Evolving
{
    public interface IEvolvingBehaviour
    {
        Task Evolve(ITerminationStrategy evolutionTerminationStrategy);
    }
}
