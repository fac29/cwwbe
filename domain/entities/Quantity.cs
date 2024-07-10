using System;

namespace domain.entities
{
    public class Quantity
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }

        public List<Ingredient> IngredientId { get; set; }
    }
}