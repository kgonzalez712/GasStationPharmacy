using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GasStationPharmacyWS.Models;

namespace GasStationPharmacyWS.Controllers
{
    [RoutePrefix("api/Recipes")]
    public class RecipeController : ApiController
    {
        /// <summary>
        /// Controladores para los metodos GET para los recetas de las dos farmacias
        /// </summary>
        /// <returns> Una Lista de recetas </returns>
        [HttpGet]
        [Route("Phischel")]
        public List<Recipe> GetAllPhischelMedicines()
        {
            return RecipeRegister.GetInstance().GetAllRecipes(RecipeRegister.repListP);
        }

        [HttpGet]
        [Route("BombaTica")]
        public List<Recipe> GetAllBombaTicaRecipes()
        {
            return RecipeRegister.GetInstance().GetAllRecipes(RecipeRegister.repListB);
        }

        /// <summary>
        /// Controladores para los metodos GET para las recetas de las dos farmacias
        /// </summary>
        /// <returns> Una receta en especifico </returns>
        [HttpGet]
        [Route("Phischel/{name}")]
        public IHttpActionResult GetPhischelRecipeById(int id)
        {
            var val = RecipeRegister.GetInstance().GetRecipe(RecipeRegister.repListP, id);
            if (val == null) return NotFound();

            return Ok(val);
        }

        [HttpGet]
        [Route("BombaTica/{name}")]
        public IHttpActionResult GetBombaTicaRecipeById(int id)
        {
            var val = RecipeRegister.GetInstance().GetRecipe(RecipeRegister.repListP, id);
            if (val == null) return NotFound();

            return Ok(val);
        }

        /// <summary>
        /// Controladores para los metodos Post para las recetas de las dos farmacias
        /// </summary>
        [HttpPost]
        [Route("Phischel/NewRecipe")]
        public HttpResponseMessage PostNewPhischelRecipe([FromBody] Recipe value)
        {
            RecipeRegister.GetInstance().AddRecipe(RecipeRegister.repListP, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        [HttpPost]
        [Route("BombaTica/NewMed")]
        public HttpResponseMessage PostNewBombaTicaRecipe([FromBody] Recipe value)
        {
            RecipeRegister.GetInstance().AddRecipe(RecipeRegister.repListB, value);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        /// <summary>
        /// Controladores para los metodos PUT para las recetas de las dos farmacias
        /// </summary>
        [HttpPut]
        [Route("Phischel/{id}/UpdateRecipe")]
        public HttpResponseMessage PutPhischelRecipe(int id, [FromBody] Recipe value)
        {
            var val = RecipeRegister.GetInstance().UpdateRecipe(RecipeRegister.repListP, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        [HttpPut]
        [Route("BombaTica/{id}/UpdateRecipe")]
        public HttpResponseMessage PutBombaTicaRecipe(int id, [FromBody] Recipe value)
        {
            var val = RecipeRegister.GetInstance().UpdateRecipe(RecipeRegister.repListB, id, value);
            if (val == false)
            {
                var responseA = Request.CreateResponse(HttpStatusCode.NotModified);
                return responseA;
            }

            var responseB = Request.CreateResponse(HttpStatusCode.Accepted);
            return responseB;
        }

        /// <summary>
        /// Controladores para los metodos DELETE para las recetas de las dos farmacias
        /// </summary>
        [HttpDelete]
        [Route("Phischel/{id}/DeleteRecipe")]
        public HttpResponseMessage DeletePhischelRecipe(int id)
        {
            var val = RecipeRegister.GetInstance().RemoveRecipe(RecipeRegister.repListP, id);
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
        public HttpResponseMessage DeleteBombaTicaRecipe(int id)
        {
            var val = RecipeRegister.GetInstance().RemoveRecipe(RecipeRegister.repListB, id);
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
