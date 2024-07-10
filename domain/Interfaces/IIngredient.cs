using System;

namespace domain.interfaces
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

    /* public class pIgredient : IIngredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void AddIngredient(IIngredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IIngredient> GetAllIngredients()
        {
            throw new NotImplementedException();
        }

        public IIngredient GetIngredientById(Guid id)
        {
            throw new NotImplementedException();
        }
    } */

}