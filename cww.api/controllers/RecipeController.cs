using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using domain.interfaces;
using domain.entities;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipe _recipeRepository;

        public RecipeController(IRecipe recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IRecipe>> GetAllRecipes()
        {
            return Ok(_recipeRepository.GetAllRecipes());
        }

        [HttpGet("{id}")]
        public ActionResult<IRecipe> GetRecipeById(Guid id)
        {
            var recipe = _recipeRepository.GetRecipeById(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

        [HttpPost]
        public ActionResult<IRecipe> CreateRecipe(IRecipe recipe)
        {
            _recipeRepository.CreateRecipe(recipe);
            return CreatedAtAction(nameof(GetRecipeById), new { id = recipe.Id }, recipe);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRecipe(Guid id)
        {
            _recipeRepository.DeleteRecipe(id);
            return NoContent();
        }
    }
}