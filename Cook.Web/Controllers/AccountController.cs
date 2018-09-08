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
            var daoResponse = AccountAdapter.GetAllUsers();
            if (daoResponse.Success)
            {
                var vm = new IndexViewModel();
                vm.Import(daoResponse.Items);
                return View(vm);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}