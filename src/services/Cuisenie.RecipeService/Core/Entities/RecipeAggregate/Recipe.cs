using Cuisenie.RecipeService.Core.Interfaces;

namespace Cuisenie.RecipeService.Core.Entities.RecipeAggregate
{
    public class Recipe : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public int Servings { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan CookTime { get; set; }
        public string PictureUrl { get; set; }
        public string VideoUrl { get; set; }
        public string ExternalUrl { get; set; }
        public string Notes { get; set; }
        public bool IsArchived { get; set; } = false;


        private List<Ingredient> _ingredients = new List<Ingredient>();
        public IEnumerable<Ingredient> Ingredients => _ingredients;

        private List<Instruction> _instructions = new List<Instruction>();
        public IEnumerable<Instruction> Instructions => _instructions;

        public Recipe() { }

        public Recipe(
            string name,
            int servings,
            TimeSpan prepTime,
            TimeSpan cookTime,
            string pictureUrl,
            string videoUrl,
            string externalUrl,
            string notes,
            bool isArchived) : this()
        {
            //TODO likely need to add more guards

            Name = name;
            Servings = servings;
            PrepTime = prepTime;
            CookTime = cookTime;
            PictureUrl = pictureUrl;
            VideoUrl = videoUrl;
            ExternalUrl = externalUrl;
            Notes = notes;
            IsArchived = isArchived;
        }
    }
}
