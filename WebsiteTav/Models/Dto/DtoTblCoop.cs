using System.Net;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Models.Dto
{
    public class DtoTblCoop
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string TellNo { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public TblCoop ToRegular()
        {
            return new TblCoop(id, Name, TellNo);
        }

        public DtoTblCoop(TblCoop coop, HttpStatusCode statusEffect)
        {
            id = coop.id;
            Name = coop.Name;
            TellNo = coop.TellNo;

            StatusEffect = statusEffect;
        }

        public DtoTblCoop()
        {
        }
    }
}