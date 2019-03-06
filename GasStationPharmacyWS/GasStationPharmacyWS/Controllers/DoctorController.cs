using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{

    [RoutePrefix("api/Doctors")]
    public class DoctorController : ApiController
    {
        /// <summary>
        /// Controladores para los metodos GET para los doctores de las dos farmacias
        /// </summary>
        /// <returns> Una Lista de doctores </returns>
        [HttpGet]
        [Route("Phischel")]
        public List<Doctor> GetAllPhischelDoctors()
        {
            return DoctorRegister.GetInstance().GetAllDoctors(DoctorRegister.docListP);
        }


        [HttpGet]
        [Route("BombaTica")]
        public List<Doctor> GetAllBombaTicaDoctors()
        {
            return DoctorRegister.GetInstance().GetAllDoctors(DoctorRegister.docListB);
        }

        /// <summary>
        /// Controladores para los metodos GET para los doctores de las dos farmacias
        /// </summary>
        /// <returns> Un doctor en especifico </returns>
        [HttpGet]
        [Route("Phischel/{id}")]
        public IHttpActionResult GetPhischelDoctorById(long id)
        {
            var val = DoctorRegister.GetInstance().GetDoctor(DoctorRegister.docListP, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        [HttpGet]
        [Route("BombaTica/{id}")]
        public IHttpActionResult GetBombaTicaDoctorById(long id)
        {
            var val = DoctorRegister.GetInstance().GetDoctor(DoctorRegister.docListB, id);
            if (val == null) return NotFound();
            return Ok(val);
        }

        /// <summary>
        /// Controladores para los metodos Post para los doctores de las dos farmacias
        /// </summary>
        [HttpPost]
        [Route("Phischel/NewDoctor")]
        public HttpResponseMessage PostNewPhischelDoctor([FromBody] Doctor value)
        {
            DoctorRegister.GetInstance().AddDoctor(DoctorRegister.docListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewDoctor")]
        public HttpResponseMessage PostNewBombaTicaDoctor([FromBody] Doctor value)
        {
            DoctorRegister.GetInstance().AddDoctor(DoctorRegister.docListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        /// <summary>
        /// Controladores para los metodos PUT para los doctores de las dos farmacias
        /// </summary>
        [HttpPut]
        [Route("Phischel/{id}/UpdateDoc")]
        public HttpResponseMessage PutPhischelDoctor(long id, [FromBody] Doctor value)
        {
            var val = DoctorRegister.GetInstance().UpdateDoctor(DoctorRegister.docListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpPut]
        [Route("BombaTica/{id}/UpdateDoc")]
        public HttpResponseMessage PutBombaTicaDoctor(long id, [FromBody] Doctor value)
        {
            var val = DoctorRegister.GetInstance().UpdateDoctor(DoctorRegister.docListB, id, value);
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
        //public HttpResponseMessage PutPhischelDoctorLNAs(long id, [FromBody] string value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorLN(DoctorRegister.docListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaDoctorLNAs(long id, [FromBody] string value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorLN(DoctorRegister.docListB, id, value);
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
        //public HttpResponseMessage PutPhischelDoctorADAs(long id, [FromBody] string value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorAD(DoctorRegister.docListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaClientADAs(long id, [FromBody] string value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorAD(DoctorRegister.docListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[Route("Phischel/{id}/UpdateB")]
        //public HttpResponseMessage PutPhischelDoctorBAs(long id, [FromBody] DateTime value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorB(DoctorRegister.docListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaDoctorBAs(long id, [FromBody] DateTime value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorB(DoctorRegister.docListB, id, value);
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
        //public HttpResponseMessage PutPhischelDoctorAPAs(long id, [FromBody] string value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorAP(DoctorRegister.docListP, id, value);
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
        //public HttpResponseMessage PutBombaTicaDoctorAPAs(long id, [FromBody] string value)
        //{
        //    var val = DoctorRegister.GetInstance().UpdateDoctorAP(DoctorRegister.docListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        /// <summary>
        /// Controladores para los metodos DELETE para los doctores de las dos farmacias
        /// </summary>
        [HttpDelete]
        [Route("Phischel/{id}/DeleteDoctor")]
        public HttpResponseMessage DeleteDoctorClient(long id)
        {
            var val = DoctorRegister.GetInstance().RemoveDoctor(DoctorRegister.docListP, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpDelete]
        [Route("BombaTica/{id}/DeleteDoctor")]
        public HttpResponseMessage DeleteBombaTicaDoctor(long id)
        {
            var val = DoctorRegister.GetInstance().RemoveDoctor(DoctorRegister.docListB, id);
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