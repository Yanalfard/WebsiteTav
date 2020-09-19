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
    [RoutePrefix("api/ProductCore")]
    public class ProductController : ApiController
    {
        [Route("AddProduct")]
        [HttpPost]
        public IHttpActionResult AddProduct(TblProduct product)
        {
            var task = Task.Run(() => new ProductService().AddProduct(product));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblProduct(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteProduct")]
        [HttpPost]
        public IHttpActionResult DeleteProduct(int id)
        {
            var task = Task.Run(() => new ProductService().DeleteProduct(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateProduct")]
        [HttpPost]
        public IHttpActionResult UpdateProduct(List<object> productLogId)
        {
            TblProduct product = JsonConvert.DeserializeObject<TblProduct>(productLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(productLogId[1].ToString());
            var task = Task.Run(() => new ProductService().UpdateProduct(product, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllProducts")]
        [HttpGet]
        public IHttpActionResult SelectAllProducts()
        {
            var task = Task.Run(() => new ProductService().SelectAllProducts());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblProduct> dto = new List<DtoTblProduct>();
                    foreach (TblProduct obj in task.Result)
                        dto.Add(new DtoTblProduct(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectProductById")]
        [HttpPost]
        public IHttpActionResult SelectProductById(int id)
        {
            var task = Task.Run(() => new ProductService().SelectProductById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblProduct(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectProductByName")]
        [HttpPost]
        public IHttpActionResult SelectProductByName(string name)
        {
            var task = Task.Run(() => new ProductService().SelectProductByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblProduct(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectProductByTellNo")]
        [HttpPost]
        public IHttpActionResult SelectProductByTellNo(string tellNo)
        {
            var task = Task.Run(() => new ProductService().SelectProductByTellNo(tellNo));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblProduct(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectProductByProductName")]
        [HttpPost]
        public IHttpActionResult SelectProductByProductName(string productName)
        {
            var task = Task.Run(() => new ProductService().SelectProductByProductName(productName));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblProduct(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}
