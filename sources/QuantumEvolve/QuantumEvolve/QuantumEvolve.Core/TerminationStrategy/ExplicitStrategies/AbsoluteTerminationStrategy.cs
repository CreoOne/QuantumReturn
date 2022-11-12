namespace QuantumEvolve.Core.TerminationStrategy.ExplicitStrategies
{
    public class AbsoluteTerminationStrategy : ITerminationStrategy
    {
        private DateTime EndDate { get; set; } = DateTime.MaxValue;

        public AbsoluteTerminationStrategy SetTerminationDateTime(DateTime dateTime)
        {
            EndDate = dateTime;
            return this;
        }

        public bool ShouldContinue()
            => DateTime.UtcNow < EndDate;

        public IEnumerable<string> GetTerminationReasons()
        {
            if (ShouldContinue())
                yield break;

            var roudTrip = EndDate.ToString("O");
            yield return $"Exceeded absolute end date and time {roudTrip}";
        }
    }
}
