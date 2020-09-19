using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Impl;
using WebsiteTav.Services.Api;

namespace WebsiteTav.Services.Impl
{
    public class StartService : IStartService
    {
        public TblStart AddStart(TblStart start)
        {
            return (TblStart)new StartRepo().AddStart(start);
        }
        public bool DeleteStart(int id)
        {
            return new StartRepo().DeleteStart(id);
        }
        public bool UpdateStart(TblStart start, int logId)
        {
            return new StartRepo().UpdateStart(start, logId);
        }
        public List<TblStart> SelectAllStarts()
        {
            return new StartRepo().SelectAllStarts();
        }
        public TblStart SelectStartById(int id)
        {
            return (TblStart)new StartRepo().SelectStartById(id);
        }
        public TblStart SelectStartByName(string name)
        {
            return new StartRepo().SelectStartByName(name);
        }
        public TblStart SelectStartByTellNo(string tellNo)
        {
            return new StartRepo().SelectStartByTellNo(tellNo);
        }

    }
}