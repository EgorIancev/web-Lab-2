using myshop.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myshop.Models
{
    public class ProductPageModel : NavbarModel
    {
        public ProductDTO Product { get; set; }
    }
}