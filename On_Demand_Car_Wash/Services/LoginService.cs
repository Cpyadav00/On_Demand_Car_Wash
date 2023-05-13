using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Services
{
    public class LoginService
    {
        ILogin<Login, int> _repository;
        public LoginService(ILogin<Login, int> repository)
        {
            _repository = repository;
        }

        public async Task<int> Login(Login login)
        {
            return await _repository.Login(login);
        }
    }
}
