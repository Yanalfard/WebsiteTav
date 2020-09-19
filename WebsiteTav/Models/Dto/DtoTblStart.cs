using System.Net;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Models.Dto
{
    public class DtoTblStart
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string TellNo { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string SocialMediaLink { get; set; }
        public int Status { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public TblStart ToRegular()
        {
            return new TblStart(id, Name, TellNo, Description, Brand, SocialMediaLink, Status);
        }

        public DtoTblStart(TblStart start, HttpStatusCode statusEffect)
        {
            id = start.id;
            Name = start.Name;
            TellNo = start.TellNo;
            Description = start.Description;
            Brand = start.Brand;
            SocialMediaLink = start.SocialMediaLink;
            Status = start.Status;

            StatusEffect = statusEffect;
        }

        public DtoTblStart()
        {
        }
    }
}