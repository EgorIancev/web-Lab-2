using myshop.BusinessLogic.API;
using myshop.BusinessLogic.Interfaces;
using myshop.Domain;
using myshop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myshop.BusinessLogic
{
    public class MyBusinessLogic
    {
        public MyBusinessLogic()
        {
            Database = new UnitOfWork("myshop");
        }

        IUnitOfWork Database { get; }

        IUserAPI userAPI;
        IProductAPI productAPI;
        IAdminAPI adminAPI;

        public IUserAPI UserAPI
        {
            get
            {
                if (userAPI == null)
                    userAPI = new UserAPI(Database);
                return userAPI;
            }
        }
        public IProductAPI ProductAPI
        {
            get
            {
                if (productAPI == null)
                    productAPI = new ProductAPI(Database);
                return productAPI;
            }
        }
        public IAdminAPI AdminAPI
        {
            get
            {
                if (adminAPI == null)
                    adminAPI = new AdminAPI(Database);
                return adminAPI;
            }
        }
    }
}