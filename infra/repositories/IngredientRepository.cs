using System;


namespace Infra.Repositories
{
    public class RecipeRepository : IRecipe
    {
        // Implement IRecipeRepository methods
        public async Task<IEnumerable<IRecipe>> GetAllRecipesAsync()
        {
            // Implementation
            throw new NotImplementedException();
        }

        public async Task<IRecipe> GetRecipeByIdAsync(Guid id)
        {
            // Implementation
            throw new NotImplementedException();
        }

        public async Task CreateRecipeAsync(IRecipe recipe)
        {
            // Implementation
            throw new NotImplementedException();
        }

        public async Task DeleteRecipeAsync(Guid id)
        {
            // Implementation
            throw new NotImplementedException();
        }
    }

}