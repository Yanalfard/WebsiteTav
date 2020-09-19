using System.Collections.Generic;
using System.Linq;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Api;
using WebsiteTav.Utilities;

namespace WebsiteTav.Repositories.Impl
{
    public class ProductRepo : IProductRepo
    {
        public TblProduct AddProduct(TblProduct product)
        {
            return (TblProduct)new MainProvider().Add(product);
        }
        public bool DeleteProduct(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblProduct, id);
        }
        public bool UpdateProduct(TblProduct product, int logId)
        {
            return new MainProvider().Update(product, logId);
        }
        public List<TblProduct> SelectAllProducts()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblProduct).Cast<TblProduct>().ToList();
        }
        public TblProduct SelectProductById(int id)
        {
            return (TblProduct)new MainProvider().SelectById(MainProvider.Tables.TblProduct, id);
        }
        public TblProduct SelectProductByName(string name)
        {
            return new MainProvider().SelectProductByName(name);
        }
        public TblProduct SelectProductByTellNo(string tellNo)
        {
            return new MainProvider().SelectProductByTellNo(tellNo);
        }
        public TblProduct SelectProductByProductName(string productName)
        {
            return new MainProvider().SelectProductByProductName(productName);
        }

    }
}