using System.Collections.Generic;
using System.Linq;
using WebsiteTav.Models.Regular;
using WebsiteTav.Repositories.Api;
using WebsiteTav.Utilities;

namespace WebsiteTav.Repositories.Impl
{
    public class StartRepo : IStartRepo
    {
        public TblStart AddStart(TblStart start)
        {
            return (TblStart)new MainProvider().Add(start);
        }
        public bool DeleteStart(int id)
        {
            return new MainProvider().Delete(MainProvider.Tables.TblStart, id);
        }
        public bool UpdateStart(TblStart start, int logId)
        {
            return new MainProvider().Update(start, logId);
        }
        public List<TblStart> SelectAllStarts()
        {
            return new MainProvider().SelectAll(MainProvider.Tables.TblStart).Cast<TblStart>().ToList();
        }
        public TblStart SelectStartById(int id)
        {
            return (TblStart)new MainProvider().SelectById(MainProvider.Tables.TblStart, id);
        }
        public TblStart SelectStartByName(string name)
        {
            return new MainProvider().SelectStartByName(name);
        }
        public TblStart SelectStartByTellNo(string tellNo)
        {
            return new MainProvider().SelectStartByTellNo(tellNo);
        }

    }
}