using myshop.BusinessLogic;
using myshop.BusinessLogic.DataTransfer;
using myshop.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myshop.Controllers
{
    public abstract class BaseController : Controller
    {
        private MyBusinessLogic Bl { get; }

        protected BaseController()
        {
            Bl = new MyBusinessLogic();
        }

        protected IUserAPI UserAPI => Bl.UserAPI;
        protected IProductAPI ProductAPI => Bl.ProductAPI;
        protected IAdminAPI AdminAPI => Bl.AdminAPI;
        protected UserDTO LoggedUser => UserAPI.GetUser(User.Identity.Name);

    }
}