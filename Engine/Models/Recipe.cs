namespace Engine.Models
{
    public class Recipe
    {
        public Step[] Steps { get; }

        public Recipe(Step[] steps)
        {
            Steps = steps;
        }
    }

    public class RecipeObject
    {
        public string Name { get; set; }
    }

    public class Ingredient : RecipeObject
    {
        public Measurement Quantity { get; set; }

        public override string ToString()
        {
            return $"{Quantity} {Name}";
        }
    }

    public abstract class Measurement
    {
        public string Unit { get; set; }
        public float Quantity { get; set; }

        public override string ToString()
        {
            return $"{Quantity} {Unit}";
        }
    }
}
