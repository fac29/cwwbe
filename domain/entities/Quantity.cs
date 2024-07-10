using System;
using domain.interfaces;

namespace domain.entities
{
    public class Quantity : IQuantity
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }

        public List<Ingredient> IngredientId { get; set; }
        public List<IIngredient> Ingredients { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Quantity(Guid id, int amount, string unit)
        {
            Id = id;
            Amount = amount;
            Unit = unit;
        }

        public IEnumerable<IQuantity> GetAllQuantities()
        {
            throw new NotImplementedException();
        }

        public IQuantity GetQuantityById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddQuantity(IQuantity quantity)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuantity(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}