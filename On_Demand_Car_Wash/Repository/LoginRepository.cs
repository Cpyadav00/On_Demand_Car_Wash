﻿using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.SqlParser.Metadata;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;
using System.Security.Cryptography;
using System.Text;

namespace On_Demand_Car_Wash.Repository
{
    public class LoginRepository : ILogin<Login, int>
    {
        CarDbContext _context;
        public LoginRepository(CarDbContext context) => _context = context;
        #region Login
        /// <summary>
        /// this method is used to Login
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> Login(Login item)
        {
            try
            {
                if (item.Role == "Admin")
                {
                    var user = await _context.Admins.SingleOrDefaultAsync(x => x.AdminEmail == item.Email);
                    if (user == null)
                    {
                        return 404;
                    }
                    else if (user.AdminPassword != item.Password)
                    {
                        return 401;
                    }
                    else
                    {
                        return 200;
                    }


                }
                else
                {
                    var user = await _context.Users.SingleOrDefaultAsync(x => x.UserEmail == item.Email);

                    if (user == null)
                    {
                        return 404;
                    }
                    else
                    {


                        if (user.Role == item.Role && user.UserStatus == "ACTIVE")
                        {
                            using var hmac = new HMACSHA512(user.UserPasswordSalt);

                            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(item.Password));

                            for (int i = 0; i < hash.Length; i++)
                            {
                                if (hash[i] != user.UserPasswordHash[i])
                                {
                                    return 401;
                                }

                            }
                        }
                        else
                        {
                            return 400;
                        }
                    }
                    return 200;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
        #endregion
    }
}
