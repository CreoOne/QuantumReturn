namespace QuantumEvolve.Core.TerminationStrategy
{
    public class DefaultTerminationStrategy : ITerminationStrategy
    {
        public HashSet<ITerminationStrategy> Strategies { get; private set; }

        public DefaultTerminationStrategy(IEnumerable<ITerminationStrategy> stoppingStrategies = null)
            => Strategies = new(stoppingStrategies ?? Enumerable.Empty<ITerminationStrategy>());

        public DefaultTerminationStrategy Add(ITerminationStrategy terminationStrategy)
        {
            Strategies.Add(terminationStrategy);
            return this;
        }

        public bool ShouldContinue()
            => Strategies.All(strategy => strategy.ShouldContinue());

        public IEnumerable<string> GetTerminationReasons()
            => Strategies.SelectMany(strategy => strategy.GetTerminationReasons());
    }
}
