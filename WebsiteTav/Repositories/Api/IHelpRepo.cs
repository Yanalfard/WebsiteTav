using System.Collections.Generic;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Repositories.Api
{
    public interface IHelpRepo
    {
        TblHelp AddHelp(TblHelp help);
        bool DeleteHelp(int id);
        bool UpdateHelp(TblHelp help, int logId);
        List<TblHelp> SelectAllHelps();
        TblHelp SelectHelpById(int id);
        TblHelp SelectHelpByName(string name);
        TblHelp SelectHelpByEmail(string email);

    }
}