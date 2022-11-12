namespace QuantumEvolve.Core.TerminationStrategy.ExplicitStrategies
{
    public class FruitlessIterationsTerminationStrategy : ITerminationStrategy
    {
        private ulong Iterations { get; set; }
        private ulong IterationsLimit { get; set; } = 1;

        public FruitlessIterationsTerminationStrategy SetFruitlessIterationsLimit(ulong limit)
        {
            IterationsLimit = limit;
            return this;
        }

        public FruitlessIterationsTerminationStrategy IncrementFruitlessIteration()
        {
            Iterations++;
            return this;
        }

        public FruitlessIterationsTerminationStrategy ResetIterations()
        {
            Iterations = 0;
            return this;
        }

        public bool ShouldContinue()
            => Iterations < IterationsLimit;

        public IEnumerable<string> GetTerminationReasons()
        {
            if (ShouldContinue())
                yield break;

            yield return $"Did {Iterations} iterations without finding better result";
        }
    }
}
