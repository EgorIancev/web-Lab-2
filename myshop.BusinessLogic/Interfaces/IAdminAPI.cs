using myshop.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myshop.BusinessLogic.Interfaces
{
    public interface IAdminAPI
    {
        void AddProduct(ProductDTO productDTO, string imageUrl, string directory);
        void DeleteProduct(int productId, string directory);
    }
}
