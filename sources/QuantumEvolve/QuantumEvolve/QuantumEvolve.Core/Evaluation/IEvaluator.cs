namespace QuantumEvolve.Core.Evaluation
{
    public interface IEvaluator<TEntity>
    {
        Task<double> Evaluate(TEntity entity);
    }
}
