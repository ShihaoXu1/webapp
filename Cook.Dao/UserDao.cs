using Cook.Common;
using Cook.Data;
using Cook.DataContracts.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook.Dao
{
    public class UserDao
    {
        public ListResponse<UserContract> GetAllUsers()
        {
            var response = new ListResponse<UserContract>();            

            try
            {
                using (var context = new CookEntities())
                {
                    response.Items = context.Users.Select(n => new UserContract()
                    {
                        UserName = n.UserName,
                        Email = n.Email
                    }).ToList();
                }
            }
            catch(Exception)
            {
                response.Success = false;
            }

            response.Success = true;

            return response;
        }
    }
}
