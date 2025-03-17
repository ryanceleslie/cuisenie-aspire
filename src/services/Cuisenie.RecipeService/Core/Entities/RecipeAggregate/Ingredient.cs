namespace Cuisenie.RecipeService.Core.Entities.RecipeAggregate
{
    public class Ingredient : BaseEntity
    {
        public decimal Quantity { get; set; }
        public string Measurement { get; set; }
        public Food Food { get; set; }
        public string Description { get; set; }

        public Ingredient() { }

        public Ingredient(decimal quantity, string measurement, Food food, string description)
        {
            Quantity = quantity;
            Measurement = measurement;
            Food = food;
            Description = description;
        }
    }
}
