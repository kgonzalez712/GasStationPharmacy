using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyWS.Models
{
    public class Recipe
    {
        public int RecipeNumber { get; set; }
        public string RecipeDoc { get; set; }
        public string RecipeMed { get; set; }
        public string RecipeUrl { get; set; }
    }
}