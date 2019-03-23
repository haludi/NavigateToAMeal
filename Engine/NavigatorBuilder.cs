using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class NavigatorBuilder
    {
        public Navigator Build(IEnumerable<Recipe> recipes)
        {
            var ordered = recipes.OrderBy(r => r.Steps.OfType<WaitStep>().Sum(w => w.Time.Second));

            return new Navigator(ordered);
        }
    }
}
