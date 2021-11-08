using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Cocktail
    {
        private List<object> _ingredients = new List<object>();

        public void AddIngredient(string ingredient)
        {
            this._ingredients.Add(ingredient);
        }

        public void ListIngredients()
        {
            string str = "Cocktail ingredients:";
            //Console.WriteLine(_ingredients[0]);

            for (int i = 0; i < this._ingredients.Count; i++)
            {
                str += "\n\t-" + _ingredients[i];
            }

            // str = str.Remove(str.Length - 2);

            Console.WriteLine(str + "\n");
        }
    }
}
