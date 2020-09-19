namespace WebsiteTav.Models.Regular
{
    public class TblHelp
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public TblHelp(int id)
        {
            this.id = id;
        }

		public TblHelp(int id, string name, string email, string description)
        {
            this.id = id;
            Name = name;
            Email = email;
            Description = description;
        }
        public TblHelp(string name, string email, string description)
        {
            Name = name;
            Email = email;
            Description = description;
        }

        public TblHelp()
        {
            
        }
    }
}