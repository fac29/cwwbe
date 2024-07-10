using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using domain.entities;
using domain.interfaces;
using infra.Data;

namespace infra.Repositories
{
    public class RecipeRepository : IRecipe
    {
        private readonly ApplicationDbContext _context;

        public Guid Id => throw new NotImplementedException();

        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Instructions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IQuantity> Quantities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CookTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RecipeType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RecipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Recipe>> GetAllRecipesAsync()
        {
            return await _context.Recipes.ToListAsync();
        }

        public async Task<Recipe> GetRecipeByIdAsync(Guid id)
        {
            return await _context.Recipes.FindAsync(id);
        }

        public async Task CreateRecipeAsync(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRecipeAsync(Guid id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
                await _context.SaveChangesAsync();
            }
        }

        public IEnumerable<IRecipe> GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public IRecipe GetRecipeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void CreateRecipe(IRecipe recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(Guid id)
        {
            throw new NotImplementedException();
        }

        // Implement other methods as needed, such as updating a recipe
    }
}