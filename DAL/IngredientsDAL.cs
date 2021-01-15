using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Models;

namespace BurgerApp.DAL
{
    public interface IIngredientsDAL
    {
        Ingredient GetIngredients();
    }
    public class IngredientsDAL: IIngredientsDAL
    {
        private readonly reactmyburgerContext _context;

        public IngredientsDAL(reactmyburgerContext context)
        {
            _context = context;
        }

        //GET ingredients
        public Ingredient GetIngredients()
        {
            return _context.Ingredients.First();
        }

        //Disposing
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            };
        }
    }
}
