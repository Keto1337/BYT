using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new CocktailBuilder();
            director.cocktailBuilder = builder;

            Console.WriteLine("Mojito");
            director.buildMojito();
            builder.GetCocktail().ListIngredients();

            Console.WriteLine("Martini");
            director.buildMartini();
            builder.GetCocktail().ListIngredients();

            Console.WriteLine("Daiquiri");
            director.buildDaiquiri();
            builder.GetCocktail().ListIngredients();

            Console.WriteLine("Daiquiri with strawberry");
            director.buildDaiquiri(true);
            builder.GetCocktail().ListIngredients();

            Console.WriteLine("Pina Colada");
            director.buildPinaColada();
            builder.GetCocktail().ListIngredients();

            Console.WriteLine("Custom Cocktail");
            builder.AddVodka();
            builder.AddSoda();
            builder.AddPineapple();
            builder.GetCocktail().ListIngredients();
        }
    }
}
