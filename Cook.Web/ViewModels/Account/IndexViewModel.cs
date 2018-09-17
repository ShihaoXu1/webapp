using Cook.DataContracts.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cook.Web.ViewModels.Account
{
    public class IndexViewModel
    {
        public List<string> UserNames { get; set; } = new List<string>();

        public void Import(List<UserContract> users)
        {
            if (users.Any())
            {
                UserNames = users.Select(n => n.UserName + " " + n.Email).ToList();
            }
        }

    }
}