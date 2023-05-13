using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface
{
    public interface IRegister<TEntity, TKey> where TEntity : class
    {
        Task<ActionResult<UserDetails>> CreateAsync(TEntity item);
        bool UserExists(TEntity item);
    }
}
