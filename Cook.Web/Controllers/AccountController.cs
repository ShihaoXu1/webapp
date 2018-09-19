using Cook.Adapter;
using Cook.Web.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cook.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            var daoResponse1 = AccountAdapter.GetAllUsers();
            var daoResponse2 = AccountAdapter.GetAllCategories();
            if (daoResponse1.Success)
            {
                var vm = new IndexViewModel();
                vm.Import(daoResponse1.Items,daoResponse2.Items);
                return View(vm);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}