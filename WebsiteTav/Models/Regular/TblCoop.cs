namespace WebsiteTav.Models.Regular
{
    public class TblCoop
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string TellNo { get; set; }

        public TblCoop(int id)
        {
            this.id = id;
        }

		public TblCoop(int id, string name, string tellNo)
        {
            this.id = id;
            Name = name;
            TellNo = tellNo;
        }
        public TblCoop(string name, string tellNo)
        {
            Name = name;
            TellNo = tellNo;
        }

        public TblCoop()
        {
            
        }
    }
}