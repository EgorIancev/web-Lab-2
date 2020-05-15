using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myshop.Domain.Entities.User;
using System.Data.Entity;

namespace myshop.BusinessLogic.Core
{
    internal class UserContext : DbContext
    {
        public UserContext() :
        base("name=eUseControl") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}