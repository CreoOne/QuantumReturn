namespace QuantumEvolve.Core.TerminationStrategy.ExplicitStrategies
{
    public class CancellationTokenTerminationStrategy : ITerminationStrategy
    {
        public CancellationToken CancellationToken { get; }

        public CancellationTokenTerminationStrategy(CancellationToken cancellationToken)
            => CancellationToken = cancellationToken;

        public IEnumerable<string> GetTerminationReasons()
        {
            if (ShouldContinue())
                yield break;

            yield return "Cancellation requested";
        }

        public bool ShouldContinue()
            => !CancellationToken.IsCancellationRequested;
    }
}
