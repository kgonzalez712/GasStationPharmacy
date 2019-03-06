using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Roles")]
    public class RoleController : ApiController
    {

        /// <summary>
        /// Controladores para los metodos GET para los roles de las dos farmacias
        /// </summary>
        /// <returns> Una Lista de roles </returns>
        [HttpGet]
        [Route("Phischel")]
        public List<Role> GetAllPhischelRoles()
        {
            return RoleRegister.GetInstance().GetAllRole(RoleRegister.roleListP);
        }

        [HttpGet]
        [Route("BombaTica")]
        public List<Role> GetAllBombaTicaRoles()
        {
            return RoleRegister.GetInstance().GetAllRole(RoleRegister.roleListB);
        }

        /// <summary>
        /// Controladores para los metodos GET para los roles de las dos farmacias
        /// </summary>
        /// <returns> Un rol en especifico </returns>
        [HttpGet]
        [Route("Phischel/{name}")]
        public IHttpActionResult GetPhischelRoleById(string name)
        {
            var val = RoleRegister.GetInstance().GetRole(RoleRegister.roleListP, name);
            if (val == null) return NotFound();
            return Ok(val);
        }

        [HttpGet]
        [Route("BombaTica/{name}")]
        public IHttpActionResult GetBombaTicaRoleById(string name)
        {
            var val = RoleRegister.GetInstance().GetRole(RoleRegister.roleListB, name);
            if (val == null) return NotFound();
            return Ok(val);
        }

        /// <summary>
        /// Controladores para los metodos Post para los roles de las dos farmacias
        /// </summary>
        [HttpPost]
        [Route("Phischel/NewRole")]
        public HttpResponseMessage PostNewPhischelRole([FromBody] Role value)
        {
            RoleRegister.GetInstance().AddRole(RoleRegister.roleListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewRole")]
        public HttpResponseMessage PostNewBombaTicaRole([FromBody] Role value)
        {
            RoleRegister.GetInstance().AddRole(RoleRegister.roleListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        /// <summary>
        /// Controladores para los metodos PUT para los roles de las dos farmacias
        /// </summary>
        [HttpPut]
        [Route("Phischel/{id}/UpdateRole")]
        public HttpResponseMessage PutPhischelRole(string id, [FromBody] Role value)
        {
            var val = RoleRegister.GetInstance()
                .UpdateRole(RoleRegister.roleListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpPut]
        [Route("BombaTica/{id}/UpdateRole")]
        public HttpResponseMessage PutBombaTicaRole(string id, [FromBody] Role value)
        {
            var val = RoleRegister.GetInstance().UpdateRole(RoleRegister.roleListB, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        /// <summary>
        /// Controladores para los metodos DELETE para los roles de las dos farmacias
        /// </summary>
        [HttpDelete]
        [Route("Phischel/{id}/DeleteRole")]
        public HttpResponseMessage DeletePhischelRole(string id)
        {
            var val = RoleRegister.GetInstance().Remove(RoleRegister.roleListP, id);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpDelete]
        [Route("BombaTica/{id}/DeleteRole")]
        public HttpResponseMessage DeleteBombaTicaRole(string id)
        {
            var val = RoleRegister.GetInstance().Remove(RoleRegister.roleListB, id);
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
