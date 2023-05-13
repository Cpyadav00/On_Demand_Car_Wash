using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.DTO;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Services
{
    public class RegisterService
    {
        IRegister<CreateUserDto, UserDetails> _repository;


        public RegisterService(IRegister<CreateUserDto, UserDetails> repository)
        {
            _repository = repository;
        }


        public async Task<ActionResult<UserDetails>> RegisterUser(CreateUserDto userprofiledto)
        {
            return await _repository.CreateAsync(userprofiledto);
        }
        public bool UserExisits(CreateUserDto email)
        {
            return _repository.UserExists(email);
        }
    }
}
