using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using BurgerApp.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BurgerApp.Models;
using Microsoft.AspNetCore.Cors;

namespace BurgerApp.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsDAL _ingredientsDal;

        public IngredientsController(IIngredientsDAL ingredientsDal)
        {
            _ingredientsDal = ingredientsDal;
        }
        // GET: api/Ingredients
        [HttpGet]
        public Ingredient GetIngredients()
        {
            return  _ingredientsDal.GetIngredients();
        }

    }
}
