using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyWS.Models
{
    public class RecipeRegister
    {
        public static List<Recipe> repListB;
        public static List<Recipe> repListP;
        private static RecipeRegister repReg;

        private RecipeRegister()
        {
            repListB = new List<Recipe>();
            repListP = new List<Recipe>();

            var a = new Recipe();
            a.RecipeNumber = 100;
            a.RecipeUrl = "no";
            a.RecipeDoc = "DOc1";
            a.RecipeMed = "mucha medicinas";


            repListB.Add(a);
            repListP.Add(a);
        }

        /// <summary>
        /// Maneja una sola instancia de receta para tratar las adicionies, modificaciones y eliminaciones de clase con cada llamado del controlador
        /// </summary>
        /// <returns></returns>
        public static RecipeRegister GetInstance()
        {
            if (repReg == null)
            {
                repReg = new RecipeRegister();
                return repReg;
            }

            return repReg;
        }


        /// <summary>
        /// retorna las recetas para las dos farmacias
        /// </summary>
        /// <returns> Una Lista de recetas </returns>
        public List<Recipe> GetAllRecipes(List<Recipe> list)
        {
            return list;
        }

        /// <summary>
        /// retorna una receta para las dos farmacias
        /// </summary>
        /// <returns> Una receta </returns>
        public Recipe GetRecipe(List<Recipe> list, int id)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.RecipeNumber.Equals(id)) return c;
            }

            return null;
        }

        /// <summary>
        /// Añade receta para las dos farmacias
        /// </summary>
        /// <returns> false si no se crea, true si se crea </returns>
        public void AddRecipe(List<Recipe> list, Recipe rep)
        {
            list.Add(rep);
        }


        /// <summary>
        /// Elimina recetas para las dos farmacias
        /// </summary>
        /// <returns> false si no lo elimina, true si lo elimina </returns
        public bool RemoveRecipe(List<Recipe> list, int id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.RecipeNumber.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }


        /// <summary>
        /// modifica recetas para las dos farmacias
        /// </summary>
        /// <returns> false si no lo modifica, true si lo modifica </returns>
        public bool UpdateRecipe(List<Recipe> list, int id, Recipe value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.RecipeNumber.Equals(id))
                {
                    list.RemoveAt(i);
                    list.Add(value);
                    action = true;
                    return action;
                }
            }

            return action;
        }
    }
}