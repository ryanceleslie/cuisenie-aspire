namespace Cuisenie.RecipeService.Core.Entities.RecipeAggregate
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public int KrogerId { get; set; } // this may be something to put in a different microservice
        public string BrandName { get; set; } // this may be something to put in a different microservice

        public Food() { }
    }
}
