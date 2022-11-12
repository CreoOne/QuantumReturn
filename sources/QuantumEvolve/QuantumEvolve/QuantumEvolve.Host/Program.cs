using QuantumEvolve.Core.Evolving;
using QuantumEvolve.Core.TerminationStrategy;
using QuantumEvolve.Core.TerminationStrategy.ExplicitStrategies;

namespace QuantumEvolve.Host
{
    internal class Program
    {
        internal static async Task Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var evolvingBehaviouir = new DefaultEvolvingBehaviour();
            var evolutionTerminationStrategy = new DefaultTerminationStrategy()
                .Add(new CancellationTokenTerminationStrategy(cancellationTokenSource.Token))
                .Add(new AbsoluteTerminationStrategy()
                    .SetTerminationDateTime(DateTime.UtcNow.AddMinutes(1)));

            await evolvingBehaviouir.Evolve(evolutionTerminationStrategy);
        }
    }
}