using System.Collections.Generic;
using System.Linq;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Api;
using WebsiteTav.Utilities;

namespace WebsiteTav.Repositories.Impl
{
    public class HelpRepo : IHelpRepo
    {
        public TblHelp AddHelp(TblHelp help)
        {
            return (TblHelp)new MainProvider().Add(help);
        }
        public bool DeleteHelp(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblHelp, id);
        }
        public bool UpdateHelp(TblHelp help, int logId)
        {
            return new MainProvider().Update(help, logId);
        }
        public List<TblHelp> SelectAllHelps()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblHelp).Cast<TblHelp>().ToList();
        }
        public TblHelp SelectHelpById(int id)
        {
            return (TblHelp)new MainProvider().SelectById(MainProvider.Tables.TblHelp, id);
        }
        public TblHelp SelectHelpByName(string name)
        {
            return new MainProvider().SelectHelpByName(name);
        }
        public TblHelp SelectHelpByEmail(string email)
        {
            return new MainProvider().SelectHelpByEmail(email);
        }

    }
}