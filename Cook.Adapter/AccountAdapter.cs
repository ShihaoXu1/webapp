using Cook.Common;
using Cook.Dao;
using Cook.DataContracts.Account;
using Cook.DataContracts.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook.Adapter
{
    public class AccountAdapter : BaseAdapter
    {
        public static ListResponse<UserContract> GetAllUsers()
        {
            return new UserDao().GetAllUsers();
        }
        public static ListResponse<CategoryContract> GetAllCategories()
        {
            return new CategoryDao().GetAllCategory();
        }
    }
}
