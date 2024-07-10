using System;
using domain.interfaces;

namespace domain.entities;

public class Recipe : IRecipe
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Instructions { get; set; } = string.Empty;

    public List<Quantity> Quatities { get; set; }

    public int CookTime { get; set; }

    public string RecipeType { get; set; } = string.Empty;
    public List<IQuantity> Quantities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void CreateRecipe(IRecipe recipe)
    {
        throw new NotImplementedException();
    }

    public void DeleteRecipe(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IRecipe> GetAllRecipes()
    {
        throw new NotImplementedException();
    }

    public IRecipe GetRecipeById(Guid id)
    {
        throw new NotImplementedException();
    }
}