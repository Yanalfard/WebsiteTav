using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Impl;
using WebsiteTav.Services.Api;

namespace WebsiteTav.Services.Impl
{
    public class CoopService : ICoopService
    {
        public TblCoop AddCoop(TblCoop coop)
        {
            return (TblCoop)new CoopRepo().AddCoop(coop);
        }
        public bool DeleteCoop(int id)
        {
            return new CoopRepo().DeleteCoop(id);
        }
        public bool UpdateCoop(TblCoop coop, int logId)
        {
            return new CoopRepo().UpdateCoop(coop, logId);
        }
        public List<TblCoop> SelectAllCoops()
        {
            return new CoopRepo().SelectAllCoops();
        }
        public TblCoop SelectCoopById(int id)
        {
            return (TblCoop)new CoopRepo().SelectCoopById(id);
        }
        public TblCoop SelectCoopByName(string name)
        {
            return new CoopRepo().SelectCoopByName(name);
        }
        public TblCoop SelectCoopByTellNo(string tellNo)
        {
            return new CoopRepo().SelectCoopByTellNo(tellNo);
        }

    }
}