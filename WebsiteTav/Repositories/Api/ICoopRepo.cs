using System.Collections.Generic;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Repositories.Api
{
    public interface ICoopRepo
    {
        TblCoop AddCoop(TblCoop coop);
        bool DeleteCoop(int id);
        bool UpdateCoop(TblCoop coop, int logId);
        List<TblCoop> SelectAllCoops();
        TblCoop SelectCoopById(int id);
        TblCoop SelectCoopByName(string name);
        TblCoop SelectCoopByTellNo(string tellNo);

    }
}