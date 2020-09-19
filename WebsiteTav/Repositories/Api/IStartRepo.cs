using System.Collections.Generic;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Repositories.Api
{
    public interface IStartRepo
    {
        TblStart AddStart(TblStart start);
        bool DeleteStart(int id);
        bool UpdateStart(TblStart start, int logId);
        List<TblStart> SelectAllStarts();
        TblStart SelectStartById(int id);
        TblStart SelectStartByName(string name);
        TblStart SelectStartByTellNo(string tellNo);

    }
}