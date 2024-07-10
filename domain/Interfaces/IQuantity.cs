using System;

namespace domain.entities
{
    public interface IQuantity
    {
        Guid Id { get; }
        int Amount { get; set; }
        string Unit { get; set; }
        List<IIngredient> Ingredients { get; set; }

        // Method to retrieve all quantities
        IEnumerable<IQuantity> GetAllQuantities();

        // Method to retrieve quantity by id
        IQuantity GetQuantityById(Guid id);

        // Method to add quantities
        void AddQuantity(IQuantity quantity);

        // Method to delete quantities
        void DeleteQuantity(Guid id);
    }
}