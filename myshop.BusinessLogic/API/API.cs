using myshop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myshop.BusinessLogic.API
{
    public abstract class API
    {
        protected API(IUnitOfWork database)
        {
            Database = database;
        }
        protected IUnitOfWork Database { get; }

    }
}