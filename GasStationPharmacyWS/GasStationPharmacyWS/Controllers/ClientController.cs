using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Clients")]
    public class ClientController : ApiController
    {
        // GET: api/Clients/Phischel
        [HttpGet]
        [Route("Phischel")]
        public List<Client> GetAllPhischelClients()
        {
            return ClientRegister.GetInstance().GetAllClients(ClientRegister.clientListP);
        }

        // GET: api/Clients/BombaTica
        [HttpGet]
        [Route("BombaTica")]
        public List<Client> GetAllBombaTicaClients()
        {
            return ClientRegister.GetInstance().GetAllClients(ClientRegister.clientListB);
        }

        // GET: api/Clients/Phischel/{id}
        [HttpGet]
        [Route("Phischel/{id}")]
        public IHttpActionResult GetPhischelClientById(long id)
        {
            var val = ClientRegister.GetInstance().GetClient(ClientRegister.clientListP, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        // GET: api/Clients/BombaTica/{id}
        [HttpGet]
        [Route("BombaTica/{id}")]
        public IHttpActionResult GetBombaTicaClientById(long id)
        {
            var val = ClientRegister.GetInstance().GetClient(ClientRegister.clientListB, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        // POST: api/Clients/Phischel/NewClient
        [HttpPost]
        [Route("Phischel/NewClient")]
        public HttpResponseMessage PostNewPhischelClient([FromBody] Client value)
        {
            ClientRegister.GetInstance().AddClient(ClientRegister.clientListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewClient")]
        public HttpResponseMessage PostNewBombaTicaClient([FromBody] Client value)
        {
            ClientRegister.GetInstance().AddClient(ClientRegister.clientListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        // PUT: api/Clients/Phischel/{id}/UpdateFN
        [HttpPut]
        [Route("Phischel/{id}/UpdateClient")]
        public HttpResponseMessage PutPhischelClient(long id, [FromBody] Client value)
        {
            var val = ClientRegister.GetInstance().UpdateClient(ClientRegister.clientListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        // PUT: api/Clients/Phischel/{id}/UpdateFN
        [HttpPut]
        [Route("BombaTica/{id}/UpdateClient")]
        public HttpResponseMessage PutBombaTicaClient(long id, [FromBody] Client value)
        {
            var val = ClientRegister.GetInstance().UpdateClient(ClientRegister.clientListB, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        //// PUT: api/Clients/Phischel/{id}/UpdateFN
        //[HttpPut]
        //[Route("Phischel/{id}/UpdateFN")]
        //public HttpResponseMessage PutPhischelClientFNAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientFN(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //// PUT: api/Clients/BombaTica/{id}/UpdateFN
        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateFN")]
        //public HttpResponseMessage PutBombaTicaClientFNAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientFN(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateLN")]
        //public HttpResponseMessage PutPhischelClientLNAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientLN(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //// PUT: api/Clients/BombaTica/{id}/UpdateLN
        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateLN")]
        //public HttpResponseMessage PutBombaTicaClientLNAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientLN(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateAD")]
        //public HttpResponseMessage PutPhischelClientADAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAD(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //// PUT: api/Clients/BombaTica/{id}/UpdateAD
        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateAD")]
        //public HttpResponseMessage PutBombaTicaClientADAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAD(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[Route("Phischel/{id}/UpdateAI")]
        //public HttpResponseMessage PutPhischelClientAIAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAI(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateAI")]
        //public HttpResponseMessage PutBombaTicaClientAIAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAI(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[Route("Phischel/{id}/UpdateB")]
        //public HttpResponseMessage PutPhischelClientBAs(long id, [FromBody] DateTime value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientB(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateB")]
        //public HttpResponseMessage PutBombaTicaClientBAs(long id, [FromBody] DateTime value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientB(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateAE")]
        //public HttpResponseMessage PutPhischelClientAEAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAE(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateAE")]
        //public HttpResponseMessage PutBombaTicaClientAEAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAE(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Phischel/{id}/UpdatePN")]
        //public HttpResponseMessage PutPhischelClientPNAs(long id, [FromBody] int value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientPN(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //// PUT: api/Clients/BombaTica/{id}/UpdateAD
        //[HttpPut]
        //[Route("BombaTica/{id}/UpdatePN")]
        //public HttpResponseMessage PutBombaTicaClientPNAs(long id, [FromBody] int value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientPN(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateAP")]
        //public HttpResponseMessage PutPhischelClientAPAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAP(ClientRegister.clientListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateAP")]
        //public HttpResponseMessage PutBombaTicaClientAPAs(long id, [FromBody] string value)
        //{
        //    var val = ClientRegister.GetInstance().UpdateClientAP(ClientRegister.clientListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        [HttpDelete]
        [Route("Phischel/{id}/DeleteClient")]
        public HttpResponseMessage DeletePhischelClient(long id)
        {
            var val = ClientRegister.GetInstance().RemoveClient(ClientRegister.clientListP, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpDelete]
        [Route("BombaTica/{id}/DeleteClient")]
        public HttpResponseMessage DeleteBombaTicaClient(long id)
        {
            var val = ClientRegister.GetInstance().RemoveClient(ClientRegister.clientListB, id);
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