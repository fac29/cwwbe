using System;

namespace domain.entities
{
    public interface IIngredient
    {
        Guid Id { get; }
        string Name { get; }

        // Method to retrieve all ingredients
        IEnumerable<IIngredient> GetAllIngredients();

        // Method to retrieve an ingredient by id
        IIngredient GetIngredientById(Guid id);

        // Method to add ingredients
        void AddIngredient(IIngredient ingredient);

        // Method to delete ingredients
        void DeleteIngredient(Guid id);
    }

    // Implementation of the IIngredient interface


}