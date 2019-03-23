using Engine.Models;
using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Navigator
    {
        private class RecipeTracker
        {
            public Recipe Recipe { get; }
            public int Index { get; set; }

            public RecipeTracker(Recipe recipe)
            {
                Recipe = recipe;
            }
        }

        private RecipeTracker[] m_trackers;
        private int m_pos;

        public string Current
        {
            get
            {
                var currentTracker = m_trackers[m_pos];
                return currentTracker.Recipe.Steps[currentTracker.Index].ToString();
            }
        }

        public Navigator(IEnumerable<Recipe> recipes)
        {
            m_trackers = recipes.Select(r => new RecipeTracker(r)).ToArray();
        }

        public bool Next()
        {
            var currentTracker = m_trackers[m_pos];
            if (currentTracker.Recipe.Steps.Length <= currentTracker.Index + 1)
                return false;

            currentTracker.Index++;
            return true;
        }
    }
}