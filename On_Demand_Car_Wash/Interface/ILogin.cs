namespace On_Demand_Car_Wash.Interface
{
    public interface ILogin<TEntity, TKey> where TEntity : class
    {
        Task<int> Login(TEntity item);
    }
}
