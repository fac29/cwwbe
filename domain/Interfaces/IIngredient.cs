using System;

namespace domain.entities
{
    public interface IIngredient
    {
        Guid Id { get; }
        string Name { get; }
    }
}