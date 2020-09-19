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
    [RoutePrefix("api/StartCore")]
    public class StartController : ApiController
    {
        [Route("AddStart")]
        [HttpPost]
        public IHttpActionResult AddStart(TblStart start)
        {
            var task = Task.Run(() => new StartService().AddStart(start));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblStart(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteStart")]
        [HttpPost]
        public IHttpActionResult DeleteStart(int id)
        {
            var task = Task.Run(() => new StartService().DeleteStart(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateStart")]
        [HttpPost]
        public IHttpActionResult UpdateStart(List<object> startLogId)
        {
            TblStart start = JsonConvert.DeserializeObject<TblStart>(startLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(startLogId[1].ToString());
            var task = Task.Run(() => new StartService().UpdateStart(start, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllStarts")]
        [HttpGet]
        public IHttpActionResult SelectAllStarts()
        {
            var task = Task.Run(() => new StartService().SelectAllStarts());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblStart> dto = new List<DtoTblStart>();
                    foreach (TblStart obj in task.Result)
                        dto.Add(new DtoTblStart(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectStartById")]
        [HttpPost]
        public IHttpActionResult SelectStartById(int id)
        {
            var task = Task.Run(() => new StartService().SelectStartById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblStart(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectStartByName")]
        [HttpPost]
        public IHttpActionResult SelectStartByName(string name)
        {
            var task = Task.Run(() => new StartService().SelectStartByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblStart(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectStartByTellNo")]
        [HttpPost]
        public IHttpActionResult SelectStartByTellNo(string tellNo)
        {
            var task = Task.Run(() => new StartService().SelectStartByTellNo(tellNo));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblStart(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}
