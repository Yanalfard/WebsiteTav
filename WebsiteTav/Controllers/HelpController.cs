using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using WebsiteTav.Models.Dto;
using WebsiteTav.Models.Regular;
using WebsiteTav.Services.Impl;

namespace WebsiteTav.Controllers
{
    [RoutePrefix("api/HelpCore")]
    public class HelpController : ApiController
    {
        [Route("AddHelp")]
        [HttpPost]
        public IHttpActionResult AddHelp(TblHelp help)
        {
            var task = Task.Run(() => new HelpService().AddHelp(help));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblHelp(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteHelp")]
        [HttpPost]
        public IHttpActionResult DeleteHelp(int id)
        {
            var task = Task.Run(() => new HelpService().DeleteHelp(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateHelp")]
        [HttpPost]
        public IHttpActionResult UpdateHelp(List<object> helpLogId)
        {
            TblHelp help = JsonConvert.DeserializeObject<TblHelp>(helpLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(helpLogId[1].ToString());
            var task = Task.Run(() => new HelpService().UpdateHelp(help, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllHelps")]
        [HttpGet]
        public IHttpActionResult SelectAllHelps()
        {
            var task = Task.Run(() => new HelpService().SelectAllHelps());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblHelp> dto = new List<DtoTblHelp>();
                    foreach (TblHelp obj in task.Result)
                        dto.Add(new DtoTblHelp(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectHelpById")]
        [HttpPost]
        public IHttpActionResult SelectHelpById(int id)
        {
            var task = Task.Run(() => new HelpService().SelectHelpById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblHelp(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectHelpByName")]
        [HttpPost]
        public IHttpActionResult SelectHelpByName(string name)
        {
            var task = Task.Run(() => new HelpService().SelectHelpByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblHelp(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectHelpByEmail")]
        [HttpPost]
        public IHttpActionResult SelectHelpByEmail(string email)
        {
            var task = Task.Run(() => new HelpService().SelectHelpByEmail(email));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblHelp(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}
