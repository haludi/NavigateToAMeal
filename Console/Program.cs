using System;
using Engine.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var steps = new Step[]
            {
                new Step("Take the bowl"),
                new Step("Put the flour inside"),
                new Step("Put the dried yeast inside"),
                new Step("Put the sugar inside"),
                new Step("Mix the content of the bowl"),
                new Step("Create a hole inside the mixture"),
                new Step("Spill the water inside"),
                new Step("Spill the oil inside"),
                new Step("Knead the ingredients while adding 1/3 glass of water until you get a flexible dough"),
                new Step("Make a boll from the dough"),
                new Step("Cover the boll with a little flour"),
                new Step("Return the boll to the bowl"),
                new Step("Cover the bowl with plastic wrap"),
                new Step("Wait for 1/2 hour"),
            };
            var recipe = new Recipe(steps);

            foreach (var step in recipe.Steps)
            {
                Console.WriteLine(step);
                Console.ReadLine();
            }
        }
    }
}
