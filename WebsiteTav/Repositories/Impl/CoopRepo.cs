using System.Collections.Generic;
using System.Linq;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Api;
using WebsiteTav.Utilities;

namespace WebsiteTav.Repositories.Impl
{
    public class CoopRepo : ICoopRepo
    {
        public TblCoop AddCoop(TblCoop coop)
        {
            return (TblCoop)new MainProvider().Add(coop);
        }
        public bool DeleteCoop(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblCoop, id);
        }
        public bool UpdateCoop(TblCoop coop, int logId)
        {
            return new MainProvider().Update(coop, logId);
        }
        public List<TblCoop> SelectAllCoops()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblCoop).Cast<TblCoop>().ToList();
        }
        public TblCoop SelectCoopById(int id)
        {
            return (TblCoop)new MainProvider().SelectById(MainProvider.Tables.TblCoop, id);
        }
        public TblCoop SelectCoopByName(string name)
        {
            return new MainProvider().SelectCoopByName(name);
        }
        public TblCoop SelectCoopByTellNo(string tellNo)
        {
            return new MainProvider().SelectCoopByTellNo(tellNo);
        }

    }
}