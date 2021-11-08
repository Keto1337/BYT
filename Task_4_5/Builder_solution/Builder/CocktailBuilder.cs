using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CocktailBuilder : ICocktailBuilder
    {
        private Cocktail _cocktail = new Cocktail();

        public CocktailBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._cocktail = new Cocktail();
        }

        public void AddWhiteRome()
        {
            this._cocktail.AddIngredient("White Rome");
        }
        public void AddSugar()
        {
            this._cocktail.AddIngredient("Sugar");
        }
        public void AddSalt()
        {
            this._cocktail.AddIngredient("Salt");
        }
        public void AddLime()
        {
            this._cocktail.AddIngredient("Lime");
        }
        public void AddMint()
        {
            this._cocktail.AddIngredient("Mint");
        }
        public void AddSoda()
        {
            this._cocktail.AddIngredient("Soda");
        }
        public void AddCreamyCoconut()
        {
            this._cocktail.AddIngredient("Creamy Coconut");
        }
        public void AddPineapple()
        {
            this._cocktail.AddIngredient("Pineapple");
        }
        public void AddStrawberry()
        {
            this._cocktail.AddIngredient("Strawberry");
        }
        public void AddVodka()
        {
            this._cocktail.AddIngredient("Vodka");
        }
        public void AddGin()
        {
            this._cocktail.AddIngredient("Gin");
        }
        public void AddVermouth()
        {
            this._cocktail.AddIngredient("Vermouth");
        }
        public void AddLemon()
        {
            this._cocktail.AddIngredient("Lemon");
        }

        public Cocktail GetCocktail()
        {
            Cocktail result = this._cocktail;

            this.Reset();

            return result;
        }
    }
}
