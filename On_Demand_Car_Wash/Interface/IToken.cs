using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface
{
    public interface IToken
    {
        public string CreateToken(Login login);
    }
}
