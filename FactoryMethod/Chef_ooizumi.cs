using System.Linq;
using System.Collections;
using System.Collections.Generic;
using FactoryMethod.Sample1_framework;

namespace FactoryMethod.Sample1_ooizumi
{
    public class Chef_ooizumi : Chef
    {
        private List<Food> Historys = new List<Food>();

        protected override Food Cooking(IEnumerable<string> recipe)
        {
            if(IsContainsKeyword(
                new List<string>()
                {
                    "にんじん",
                    "じゃがいも",
                    "カレー粉"
                },
                recipe.ToList())) /* = */ return new Curry();

            return new Dust();              
        }

        private bool IsContainsKeyword(List<string> keywords,List<string> recipe)
        {
            return keywords.All(k => recipe.Any(r => k.Equals(r)));
        }

        protected override void RegisterHistory(Food target)
        {
            Historys.Add(target);
        }

        public override List<Food> GetHistory()
        {
            return Historys;
        }

    }

    public class Curry : Food
    {
        public override string Introduce()
        {
            return "私はカレー";
        }
    }

    public class Dust : Food
    {
        public override string Introduce()
        {
            return "私はゴミ";
        }
    }    
}