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

        int CookTime { get; set; }

        string RecipeType { get; set; }
        // create the method to retrieve all recipes

        // create the method to retrieve a single recipe

        // create the method to create a new recipe
    }

}