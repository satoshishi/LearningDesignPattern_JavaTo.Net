using System.Collections;
using System.Collections.Generic;

namespace FactoryMethod.Sample1_framework
{
    public abstract class Chef
    {
        protected abstract Food Cooking(IEnumerable<string> recipe);

        protected abstract void RegisterHistory(Food target);

        public abstract List<Food> GetHistory();

        public Food Order(IEnumerable<string> recipe)
        {
            Food food = Cooking(recipe);
            RegisterHistory(food);

            return food;
        }
    }
}