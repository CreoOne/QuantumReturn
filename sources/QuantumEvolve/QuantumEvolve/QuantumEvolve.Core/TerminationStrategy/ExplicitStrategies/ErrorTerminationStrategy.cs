namespace QuantumEvolve.Core.TerminationStrategy.ExplicitStrategies
{
    public class ErrorTerminationStrategy : ITerminationStrategy
    {
        private bool Minimalization { get; set; } = true;
        private double ErrorThreshold { get; set; }
        private double CurrentError { get; set; }

        public ErrorTerminationStrategy(double initialError)
            => SetCurrentError(initialError);

        public ErrorTerminationStrategy SetCurrentError(double error)
        {
            CurrentError = error;
            return this;
        }

        public ErrorTerminationStrategy SetErrorThreshold(double threshold)
        {
            ErrorThreshold = threshold;
            return this;
        }

        public ErrorTerminationStrategy UseErrorMinimalization()
        {
            Minimalization = true;
            return this;
        }

        public bool ShouldContinue()
            => Minimalization && CurrentError > ErrorThreshold || !Minimalization && CurrentError < ErrorThreshold;

        public IEnumerable<string> GetTerminationReasons()
        {
            if (ShouldContinue())
                yield break;

            yield return $"Error {CurrentError} is {(Minimalization ? "below" : "above")} threshold {ErrorThreshold}";
        }
    }
}
