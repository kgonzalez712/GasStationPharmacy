using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{

    [RoutePrefix("api/Admins")]
    public class AdminController : ApiController
    {
        /// <summary>
        /// Controladores para los metodos GET para los administradores de las dos farmacias
        /// </summary>
        /// <returns> Una Lista de administradores </returns>
        [HttpGet]
        [Route("Phischel")]
        public List<Admin> GetAllPhischelAdmins()
        {
            return AdminRegister.GetInstance().GetAllAdmins(AdminRegister.adminListP);
        }

        [HttpGet]
        [Route("BombaTica")]
        public List<Admin> GetAllBombaTicaAdmin()
        {
            return AdminRegister.GetInstance().GetAllAdmins(AdminRegister.adminListB);
        }

        /// <summary>
        /// Controladores para los metodos GET para los admin de las dos farmacias
        /// </summary>
        /// <returns> Un admin en especifico </returns>
        [HttpGet]
        [Route("Phischel/{id}")]
        public IHttpActionResult GetPhischelAdminById(long id)
        {
            var val = AdminRegister.GetInstance().GetAdmin(AdminRegister.adminListP, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        [HttpGet]
        [Route("BombaTica/{id}")]
        public IHttpActionResult GetBombaTicaAdminById(long id)
        {
            var val = AdminRegister.GetInstance().GetAdmin(AdminRegister.adminListB, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        /// <summary>
        /// Controladores para los metodos Post para los admin de las dos farmacias
        /// </summary>
        [HttpPost]
        [Route("Phischel/NewAdmin")]
        public HttpResponseMessage PostNewPhischelAdmin([FromBody] Admin value)
        {
            AdminRegister.GetInstance().AddAdmin(AdminRegister.adminListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewAdmin")]
        public HttpResponseMessage PostNewBombaTicaAdmin([FromBody] Admin value)
        {
            AdminRegister.GetInstance().AddAdmin(AdminRegister.adminListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        /// <summary>
        /// Controladores para los metodos PUT para los admin de las dos farmacias
        /// </summary>
        [HttpPut]
        [Route("Phischel/{id}/UpdateAdmin")]
        public HttpResponseMessage PutPhischelAdmin(long id, [FromBody] Admin value)
        {
            var val = AdminRegister.GetInstance().UpdateAdmin(AdminRegister.adminListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpPut]
        [Route("BombaTica/{id}/UpdateAdmin")]
        public HttpResponseMessage PutBombaTicaAdmin(long id, [FromBody] Admin value)
        {
            var val = AdminRegister.GetInstance().UpdateAdmin(AdminRegister.adminListB, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateLN")]
        //public HttpResponseMessage PutPhischelAdminLNAs(long id, [FromBody] string value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdminLN(AdminRegister.adminListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateLN")]
        //public HttpResponseMessage PutBombaTicaAdminLNAs(long id, [FromBody] string value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdminLN(AdminRegister.adminListB, id, value);
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
        //public HttpResponseMessage PutPhischelAdminADAs(long id, [FromBody] string value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdminAD(AdminRegister.adminListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaAdminADAs(long id, [FromBody] string value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdminAD(AdminRegister.adminListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[Route("Phischel/{id}/UpdateB")]
        //public HttpResponseMessage PutPhischelAdminBAs(long id, [FromBody] DateTime value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdmintB(AdminRegister.adminListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaAdminBAs(long id, [FromBody] DateTime value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdmintB(AdminRegister.adminListB, id, value);
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
        //public HttpResponseMessage PutPhischelAdminAPAs(long id, [FromBody] string value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdminAP(AdminRegister.adminListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaAdminAPAs(long id, [FromBody] string value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdminAP(AdminRegister.adminListB, id, value);
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
        //    var val = AdminRegister.GetInstance().UpdateAdminAE(AdminRegister.adminListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaAdminAEAs(long id, [FromBody] string value)
        //{
        //    var val = AdminRegister.GetInstance().UpdateAdminAE(AdminRegister.adminListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        /// <summary>
        /// Controladores para los metodos DELETE para los admin de las dos farmacias
        /// </summary>
        [HttpDelete]
        [Route("Phischel/{id}/DeleteAdmin")]
        public HttpResponseMessage DeletePhischelAdmin(long id)
        {
            var val = AdminRegister.GetInstance().RemoveAdmin(AdminRegister.adminListP, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpDelete]
        [Route("BombaTica/{id}/DeleteAdmin")]
        public HttpResponseMessage DeleteBombaTicaAdmin(long id)
        {
            var val = AdminRegister.GetInstance().RemoveAdmin(AdminRegister.adminListB, id);
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