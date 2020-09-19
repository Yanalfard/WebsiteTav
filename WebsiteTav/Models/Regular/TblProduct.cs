namespace WebsiteTav.Models.Regular
{
    public class TblProduct
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string TellNo { get; set; }
        public string Address { get; set; }
        public string ProductName { get; set; }

        public TblProduct(int id)
        {
            this.id = id;
        }

		public TblProduct(int id, string name, string tellNo, string address, string productName)
        {
            this.id = id;
            Name = name;
            TellNo = tellNo;
            Address = address;
            ProductName = productName;
        }
        public TblProduct(string name, string tellNo, string address, string productName)
        {
            Name = name;
            TellNo = tellNo;
            Address = address;
            ProductName = productName;
        }

        public TblProduct()
        {
            
        }
    }
}