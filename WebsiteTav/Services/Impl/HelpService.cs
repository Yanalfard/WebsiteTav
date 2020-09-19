using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Impl;
using WebsiteTav.Services.Api;

namespace WebsiteTav.Services.Impl
{
    public class HelpService : IHelpService
    {
        public TblHelp AddHelp(TblHelp help)
        {
            return (TblHelp)new HelpRepo().AddHelp(help);
        }
        public bool DeleteHelp(int id)
        {
            return new HelpRepo().DeleteHelp(id);
        }
        public bool UpdateHelp(TblHelp help, int logId)
        {
            return new HelpRepo().UpdateHelp(help, logId);
        }
        public List<TblHelp> SelectAllHelps()
        {
            return new HelpRepo().SelectAllHelps();
        }
        public TblHelp SelectHelpById(int id)
        {
            return (TblHelp)new HelpRepo().SelectHelpById(id);
        }
        public TblHelp SelectHelpByName(string name)
        {
            return new HelpRepo().SelectHelpByName(name);
        }
        public TblHelp SelectHelpByEmail(string email)
        {
            return new HelpRepo().SelectHelpByEmail(email);
        }

    }
}