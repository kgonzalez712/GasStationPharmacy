using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{

    [RoutePrefix("api/Medicines")]
    public class MedicineController : ApiController
    {
        /// <summary>
        /// Controladores para los metodos GET para las medicinas de las dos farmacias
        /// </summary>
        /// <returns> Una Lista de medicinas </returns>
        [HttpGet]
        [Route("Phischel")]
        public List<Medicine> GetAllPhischelMedicines()
        {
            return MedicineRegister.GetInstance().GetAllMedicines(MedicineRegister.medListP);
        }

        [HttpGet]
        [Route("BombaTica")]
        public List<Medicine> GetAllBombaTicaMedicines()
        {
            return MedicineRegister.GetInstance().GetAllMedicines(MedicineRegister.medListB);
        }

        /// <summary>
        /// Controladores para los metodos GET para las medicinas de las dos farmacias
        /// </summary>
        /// <returns> Una medicina en especifico </returns>
        [HttpGet]
        [Route("Phischel/{name}")]
        public IHttpActionResult GetPhischelMedicineById(string name)
        {
            var val = MedicineRegister.GetInstance().GetMedicine(MedicineRegister.medListP, name);
            if (val == null) return NotFound();

            return Ok(val);
        }

        [HttpGet]
        [Route("BombaTica/{name}")]
        public IHttpActionResult GetBombaTicaMedicineById(string name)
        {
            var val = MedicineRegister.GetInstance().GetMedicine(MedicineRegister.medListB, name);
            if (val == null) return NotFound();

            return Ok(val);
        }

        /// <summary>
        /// Controladores para los metodos Post para las medicinas de las dos farmacias
        /// </summary>
        [HttpPost]
        [Route("Phischel/NewMed")]
        public HttpResponseMessage PostNewPhischelMedicine([FromBody] Medicine value)
        {
            MedicineRegister.GetInstance().AddMedicine(MedicineRegister.medListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewMed")]
        public HttpResponseMessage PostNewBombaTicaMedicine([FromBody] Medicine value)
        {
            MedicineRegister.GetInstance().AddMedicine(MedicineRegister.medListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        /// <summary>
        /// Controladores para los metodos PUT para las medicinas de las dos farmacias
        /// </summary>
        [HttpPut]
        [Route("Phischel/{id}/UpdateMedicine")]
        public HttpResponseMessage PutPhischelMedicineNAs(string id, [FromBody] Medicine value)
        {
            var val = MedicineRegister.GetInstance().UpdateMedicine(MedicineRegister.medListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpPut]
        [Route("BombaTica/{id}/UpdateMedicine")]
        public HttpResponseMessage PutBombaTicaMedicineNAs(string id, [FromBody] Medicine value)
        {
            var val = MedicineRegister.GetInstance().UpdateMedicine(MedicineRegister.medListB, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateRP")]
        //public HttpResponseMessage PutPhischelMedicineRPAs(string id, [FromBody] string value)
        //{
        //    var val = MedicineRegister.GetInstance().UpdateMediceRP(MedicineRegister.medListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateRP")]
        //public HttpResponseMessage PutBombaTicaMedicineRPAs(string id, [FromBody] string value)
        //{
        //    var val = MedicineRegister.GetInstance().UpdateMediceRP(MedicineRegister.medListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Phischel/{id}/UpdateQ")]
        //public HttpResponseMessage PutPhischelMedicineQAs(string id, [FromBody] int value)
        //{
        //    var val = MedicineRegister.GetInstance().UpdateMediceQ(MedicineRegister.medListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateQ")]
        //public HttpResponseMessage PutBombaTicaMedicineQAs(string id, [FromBody] int value)
        //{
        //    var val = MedicineRegister.GetInstance().UpdateMediceQ(MedicineRegister.medListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("Pischel/{id}/UpdateP")]
        //public HttpResponseMessage PutPhischelMedicinePAs(string id, [FromBody] int value)
        //{
        //    var val = MedicineRegister.GetInstance().UpdateMediceP(MedicineRegister.medListP, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        //[HttpPut]
        //[Route("BombaTica/{id}/UpdateP")]
        //public HttpResponseMessage PutBombaTicaMedicinePAs(string id, [FromBody] int value)
        //{
        //    var val = MedicineRegister.GetInstance().UpdateMediceP(MedicineRegister.medListB, id, value);
        //    if (val == false)
        //    {
        //        var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
        //        return responseA;
        //    }

        //    var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
        //    return responseB;
        //}

        /// <summary>
        /// Controladores para los metodos DELETE para las medicinas de las dos farmacias
        /// </summary>
        [HttpDelete]
        [Route("Phischel/{id}/DeleteMedicine")]
        public HttpResponseMessage DeletePhischelMedicine(string id)
        {
            var val = MedicineRegister.GetInstance().RemoveMedicine(MedicineRegister.medListP, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpDelete]
        [Route("BombaTica/{id}/DeleteMedicine")]
        public HttpResponseMessage DeleteBombaTicaMedicine(string id)
        {
            var val = MedicineRegister.GetInstance().RemoveMedicine(MedicineRegister.medListB, id);
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