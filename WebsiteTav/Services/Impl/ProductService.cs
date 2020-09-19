using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Impl;
using WebsiteTav.Services.Api;

namespace WebsiteTav.Services.Impl
{
    public class ProductService : IProductService
    {
        public TblProduct AddProduct(TblProduct product)
        {
            return (TblProduct)new ProductRepo().AddProduct(product);
        }
        public bool DeleteProduct(int id)
        {
            return new ProductRepo().DeleteProduct(id);
        }
        public bool UpdateProduct(TblProduct product, int logId)
        {
            return new ProductRepo().UpdateProduct(product, logId);
        }
        public List<TblProduct> SelectAllProducts()
        {
            return new ProductRepo().SelectAllProducts();
        }
        public TblProduct SelectProductById(int id)
        {
            return (TblProduct)new ProductRepo().SelectProductById(id);
        }
        public TblProduct SelectProductByName(string name)
        {
            return new ProductRepo().SelectProductByName(name);
        }
        public TblProduct SelectProductByTellNo(string tellNo)
        {
            return new ProductRepo().SelectProductByTellNo(tellNo);
        }
        public TblProduct SelectProductByProductName(string productName)
        {
            return new ProductRepo().SelectProductByProductName(productName);
        }

    }
}