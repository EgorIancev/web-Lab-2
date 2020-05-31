using myshop.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myshop.Models
{
    public class AdminPageModel : NavbarModel
    {
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}