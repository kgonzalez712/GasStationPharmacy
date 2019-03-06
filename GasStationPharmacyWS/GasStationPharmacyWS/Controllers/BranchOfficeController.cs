using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [RoutePrefix("api/BranchOffices")]
    public class BranchOfficeController : ApiController
    {
        /// <summary>
        /// Controladores para los metodos GET para las sucursales de las dos farmacias
        /// </summary>
        /// <returns> Una Lista de Roles </returns>
        [HttpGet]
        [Route("Phischel")]
        public List<BranchOffice> GetAllPhischelBranches()
        {
            return BranchOfficeRegister.GetInstance().GetAllBranches(BranchOfficeRegister.branchListP);
        }

        [HttpGet]
        [Route("BombaTica")]
        public List<BranchOffice> GetAllBombaTicaBranches()
        {
            return BranchOfficeRegister.GetInstance().GetAllBranches(BranchOfficeRegister.branchListB);
        }

        /// <summary>
        /// Controladores para los metodos GET para las sucursales de las dos farmacias
        /// </summary>
        /// <returns> Una sucursal en especifico </returns>
        [HttpGet]
        [Route("Phischel/{name}")]
        public IHttpActionResult GetPhischelBranchtById(string name)
        {
            var val = BranchOfficeRegister.GetInstance().GetBranch(BranchOfficeRegister.branchListP, name);
            if (val == null) return NotFound();
            return Ok(val);
        }

        [HttpGet]
        [Route("BombaTica/{name}")]
        public IHttpActionResult GetBombaTicaBranchtById(string name)
        {
            var val = BranchOfficeRegister.GetInstance().GetBranch(BranchOfficeRegister.branchListB, name);
            if (val == null) return NotFound();
            return Ok(val);
        }

        /// <summary>
        /// Controladores para los metodos Post para las sucursales de las dos farmacias
        /// </summary>
        [HttpPost]
        [Route("Phischel/NewBranch")]
        public HttpResponseMessage PostNewPhischelBranch([FromBody] BranchOffice value)
        {
            BranchOfficeRegister.GetInstance().AddBranchOffice(BranchOfficeRegister.branchListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewBranch")]
        public HttpResponseMessage PostNewBombaTicaBranch([FromBody] BranchOffice value)
        {
            BranchOfficeRegister.GetInstance().AddBranchOffice(BranchOfficeRegister.branchListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        /// <summary>
        /// Controladores para los metodos PUT para las sucursales de las dos farmacias
        /// </summary>
        [HttpPut]
        [Route("Phischel/{id}/UpdateBranch")]
        public HttpResponseMessage PutPhischelBranch(string id, [FromBody] BranchOffice value)
        {
            var val = BranchOfficeRegister.GetInstance()
                .UpdateBranchOffice(BranchOfficeRegister.branchListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpPut]
        [Route("BombaTica/{id}/UpdateBranch")]
        public HttpResponseMessage PutBombaTicaBranch(string id, [FromBody] BranchOffice value)
        {
            var val = BranchOfficeRegister.GetInstance().UpdateBranchOffice(BranchOfficeRegister.branchListB, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateBN")]
        //public HttpResponseMessage PutPhischelBranchBNAs(string id, [FromBody] string value)
        //{
        //    var val = BranchOfficeRegister.GetInstance()
        //        .UpdateBranchOfficeN(BranchOfficeRegister.branchListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateBN")]
        //public HttpResponseMessage PutBombaTicaBrachBNAs(string id, [FromBody] string value)
        //{
        //    var val = BranchOfficeRegister.GetInstance()
        //        .UpdateBranchOfficeN(BranchOfficeRegister.branchListB, id, value);
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
        //public HttpResponseMessage PutPhischelBranchADAs(string id, [FromBody] string value)
        //{
        //    var val = BranchOfficeRegister.GetInstance()
        //        .UpdateBranchOfficeAD(BranchOfficeRegister.branchListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateAD")]
        //public HttpResponseMessage PutBombaTicaBranchADAs(string id, [FromBody] string value)
        //{
        //    var val = BranchOfficeRegister.GetInstance()
        //        .UpdateBranchOfficeAD(BranchOfficeRegister.branchListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateAN")]
        //public HttpResponseMessage PutPhischelBranchANAs(string id, [FromBody] string value)
        //{
        //    var val = BranchOfficeRegister.GetInstance()
        //        .UpdateBranchOfficeAN(BranchOfficeRegister.branchListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateAN")]
        //public HttpResponseMessage PutBombaTicaBranchANAs(string id, [FromBody] string value)
        //{
        //    var val = BranchOfficeRegister.GetInstance()
        //        .UpdateBranchOfficeAN(BranchOfficeRegister.branchListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        /// <summary>
        /// Controladores para los metodos DELETE para las sucursales de las dos farmacias
        /// </summary>
        [HttpDelete]
        [Route("Phischel/{id}/DeleteBranch")]
        public HttpResponseMessage DeletePhischelBranch(string id)
        {
            var val = BranchOfficeRegister.GetInstance().RemoveBranchOffice(BranchOfficeRegister.branchListP, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpDelete]
        [Route("BombaTica/{id}/DeleteBranch")]
        public HttpResponseMessage DeleteBombaTicaBranch(string id)
        {
            var val = BranchOfficeRegister.GetInstance().RemoveBranchOffice(BranchOfficeRegister.branchListB, id);
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