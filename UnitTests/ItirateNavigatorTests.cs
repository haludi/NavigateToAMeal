using Engine;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTests
{
    public class ItirateNavigatorTests
    {
        [Fact]
        public void ItirateNavigator_WhenOneRecipe_ShouldIterateByStepsOrders()
        {
            var builder = new NavigatorBuilder();
            Step[] steps = new[]
            {
                new Step("Do A"),
                new Step("Do B"),
            };

            var recipe = new Recipe(steps);
            IEnumerable<Recipe> recipes = new[]
            {
                recipe
            };
            var navigator = builder.Build(recipes);


            var actual = new List<string>();
            do
            {
                actual.Add(navigator.Current);
            } while (navigator.Next());

            Assert.Equal(steps.Select(s => s.ToString()).ToArray(), actual.ToArray());
        }
    }
}
