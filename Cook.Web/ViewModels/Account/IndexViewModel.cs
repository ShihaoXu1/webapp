using Cook.DataContracts.Account;
using Cook.DataContracts.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cook.Web.ViewModels.Account
{
    public class IndexViewModel
    {
        public List<string> UserNames { get; set; } = new List<string>();
        public List<string> Categories { get; set; } = new List<string>();
        public void Import(List<UserContract> users, List<CategoryContract> categories)
        {
            if (users.Any())
            {
                UserNames = users.Select(n => n.UserName + " " + n.Email).ToList();
            }
            if (categories.Any())
            {
                Categories = categories.Select(n => n.CategoryName + " " + n.CategoryIntroduction).ToList();
            }
        }

    }
}