using System.Collections.Generic;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Repositories.Api
{
    public interface IProductRepo
    {
        TblProduct AddProduct(TblProduct product);
        bool DeleteProduct(int id);
        bool UpdateProduct(TblProduct product, int logId);
        List<TblProduct> SelectAllProducts();
        TblProduct SelectProductById(int id);
        TblProduct SelectProductByName(string name);
        TblProduct SelectProductByTellNo(string tellNo);
        TblProduct SelectProductByProductName(string productName);

    }
}