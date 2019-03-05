using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrderController : ApiController
    {
        [HttpGet]
        [Route("Phischel")]
        public List<Order> GetAllPhischelOrders()
        {
            return OrderRegister.GetInstance().GetAllOrders(OrderRegister.orderListP);
        }

        [HttpGet]
        [Route("BombaTica")]
        public List<Order> GetAllBombaTicaOrders()
        {
            return OrderRegister.GetInstance().GetAllOrders(OrderRegister.orderListB);
        }

        [HttpGet]
        [Route("Phischel/{id}")]
        public IHttpActionResult GetPhischelOrderById(int id)
        {
            var val = OrderRegister.GetInstance().GetOrder(OrderRegister.orderListP, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        [HttpGet]
        [Route("BombaTica/{id}")]
        public IHttpActionResult GetBombaTicaOrderById(int id)
        {
            var val = OrderRegister.GetInstance().GetOrder(OrderRegister.orderListB, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        [HttpPost]
        [Route("Phischel/NewOrder")]
        public HttpResponseMessage PostNewPhischelOrder([FromBody] Order value)
        {
            OrderRegister.GetInstance().AddOrder(OrderRegister.orderListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewRole")]
        public HttpResponseMessage PostNewBombaTicaOrder([FromBody] Order value)
        {
            OrderRegister.GetInstance().AddOrder(OrderRegister.orderListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPut]
        [Route("Phischel/{id}/UpdateOrder")]
        public HttpResponseMessage PutPhischelOrder(int id, [FromBody] Order value)
        {
            var val = OrderRegister.GetInstance().UpdateOrder(OrderRegister.orderListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpPut]
        [Route("BombaTica/{id}/UpdateOrder")]
        public HttpResponseMessage PutBombaTicaOrder(int id, [FromBody] Order value)
        {
            var val = OrderRegister.GetInstance().UpdateOrder(OrderRegister.orderListB, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }


        [HttpDelete]
        [Route("Phischel/{id}/DeleteOrder")]
        public HttpResponseMessage DeletePhischelOrder(int id)
        {
            var val = OrderRegister.GetInstance().RemoveOrder(OrderRegister.orderListP, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpDelete]
        [Route("BombaTica/{id}/DeleteOrder")]
        public HttpResponseMessage DeleteBombaTicaRole(int id)
        {
            var val = OrderRegister.GetInstance().RemoveOrder(OrderRegister.orderListB, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }
    }
}
