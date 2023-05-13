using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class UserRepository : IRepository<UserDetails, int>
    {
        CarDbContext _context;
        public UserRepository(CarDbContext context) => _context = context;
        public async Task<int> CreateAsync(UserDetails userDetails)
        {

            _context.Users.Add(userDetails);
            await _context.SaveChangesAsync();
            var response = StatusCodes.Status201Created;
            return response;

        }

        public async Task<int> DeleteAsync(UserDetails userDetails)
        {
            _context.Users.Remove(userDetails);
            await _context.SaveChangesAsync();
            var response = StatusCodes.Status200OK;
            return response;
        }

        public bool Exists(int id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }

        public async Task<IEnumerable<UserDetails>> GetAsync()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }

        public async Task<UserDetails> GetIdAsync(int id)
        {

            return await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.UserId == id);
        }

        public async Task<int> UpdateAsync(UserDetails item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var response = StatusCodes.Status200OK;
            return response;

        }


    }

}
