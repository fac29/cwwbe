using System;
using domain.interfaces;

namespace domain.entities
{
    public class Ingredient : IIngredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Ingredient(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public IEnumerable<IIngredient> GetAllIngredients()
        {
            throw new NotImplementedException();
        }

        public IIngredient GetIngredientById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddIngredient(IIngredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}