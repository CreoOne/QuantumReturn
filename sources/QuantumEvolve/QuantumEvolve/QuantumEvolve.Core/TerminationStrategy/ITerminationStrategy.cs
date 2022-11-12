namespace QuantumEvolve.Core.TerminationStrategy
{
    public interface ITerminationStrategy
    {
        bool ShouldContinue();
        IEnumerable<string> GetTerminationReasons();
    }
}
