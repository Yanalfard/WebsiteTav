using System.Net;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Models.Dto
{
    public class DtoTblHelp
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public HttpStatusCode StatusEffect { get; set; }

        public TblHelp ToRegular()
        {
            return new TblHelp(id, Name, Email, Description);
        }

        public DtoTblHelp(TblHelp help, HttpStatusCode statusEffect)
        {
            id = help.id;
            Name = help.Name;
            Email = help.Email;
            Description = help.Description;

            StatusEffect = statusEffect;
        }

        public DtoTblHelp()
        {
        }
    }
}