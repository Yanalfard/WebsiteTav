namespace WebsiteTav.Models.Regular
{
    public class TblStart
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string TellNo { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string SocialMediaLink { get; set; }
        public int Status { get; set; }

        public TblStart(int id)
        {
            this.id = id;
        }

		public TblStart(int id, string name, string tellNo, string description, string brand, string socialMediaLink, int status)
        {
            this.id = id;
            Name = name;
            TellNo = tellNo;
            Description = description;
            Brand = brand;
            SocialMediaLink = socialMediaLink;
            Status = status;
        }
        public TblStart(string name, string tellNo, string description, string brand, string socialMediaLink, int status)
        {
            Name = name;
            TellNo = tellNo;
            Description = description;
            Brand = brand;
            SocialMediaLink = socialMediaLink;
            Status = status;
        }

        public TblStart()
        {
            
        }
    }
}