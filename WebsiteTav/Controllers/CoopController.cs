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
    [RoutePrefix("api/CoopCore")]
    public class CoopController : ApiController
    {
        [Route("AddCoop")]
        [HttpPost]
        public IHttpActionResult AddCoop(TblCoop coop)
        {
            var task = Task.Run(() => new CoopService().AddCoop(coop));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblCoop(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteCoop")]
        [HttpPost]
        public IHttpActionResult DeleteCoop(int id)
        {
            var task = Task.Run(() => new CoopService().DeleteCoop(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateCoop")]
        [HttpPost]
        public IHttpActionResult UpdateCoop(List<object> coopLogId)
        {
            TblCoop coop = JsonConvert.DeserializeObject<TblCoop>(coopLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(coopLogId[1].ToString());
            var task = Task.Run(() => new CoopService().UpdateCoop(coop, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllCoops")]
        [HttpGet]
        public IHttpActionResult SelectAllCoops()
        {
            var task = Task.Run(() => new CoopService().SelectAllCoops());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblCoop> dto = new List<DtoTblCoop>();
                    foreach (TblCoop obj in task.Result)
                        dto.Add(new DtoTblCoop(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectCoopById")]
        [HttpPost]
        public IHttpActionResult SelectCoopById(int id)
        {
            var task = Task.Run(() => new CoopService().SelectCoopById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblCoop(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectCoopByName")]
        [HttpPost]
        public IHttpActionResult SelectCoopByName(string name)
        {
            var task = Task.Run(() => new CoopService().SelectCoopByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblCoop(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectCoopByTellNo")]
        [HttpPost]
        public IHttpActionResult SelectCoopByTellNo(string tellNo)
        {
            var task = Task.Run(() => new CoopService().SelectCoopByTellNo(tellNo));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblCoop(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}
