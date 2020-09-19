using System.Net;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Models.Dto
{
    public class DtoTblProduct
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string TellNo { get; set; }
        public string Address { get; set; }
        public string ProductName { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public TblProduct ToRegular()
        {
            return new TblProduct(id, Name, TellNo, Address, ProductName);
        }

        public DtoTblProduct(TblProduct product, HttpStatusCode statusEffect)
        {
            id = product.id;
            Name = product.Name;
            TellNo = product.TellNo;
            Address = product.Address;
            ProductName = product.ProductName;

            StatusEffect = statusEffect;
        }

        public DtoTblProduct()
        {
        }
    }
}