using System;

namespace domain.entities;

public class Recipe
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Instructions { get; set; } = string.Empty;

    public List<Quantity> Quatities { get; set; }

    public int CookTime { get; set; }

    public string RecipeType { get; set; } = string.Empty;

}