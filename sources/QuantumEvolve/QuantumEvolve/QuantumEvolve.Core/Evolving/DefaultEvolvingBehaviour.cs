using QuantumEvolve.Core.TerminationStrategy;

namespace QuantumEvolve.Core.Evolving
{
    public sealed class DefaultEvolvingBehaviour : IEvolvingBehaviour
    {
        public Task Evolve(ITerminationStrategy evolutionTerminationStrategy)
        {
            // nothing to see yet
            return Task.CompletedTask;
        }
    }
}
