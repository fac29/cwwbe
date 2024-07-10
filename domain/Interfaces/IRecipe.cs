using System;

namespace domain.entities
{
    public interface IRecipe
    {
        Guid Id { get; }
        string Title { get; set; }
        string Description { get; set; }
        string ImageUrl { get; set; }

        string Instructions { get; set; }

        List<IQuantity> Quantities { get; set; }

        int CookTime { get; set; }

        string RecipeType { get; set; }
        // create the method to retrieve all recipes
        IEnumerable<IRecipe> GetAllRecipes();
        // create the method to retrieve a single recipe
        IRecipe GetRecipeById(Guid id);
        // create the method to create a new recipe
        void CreateRecipe(IRecipe recipe);
        // create the method to delete a recipe
        void DeleteRecipe(Guid id);
    }

}