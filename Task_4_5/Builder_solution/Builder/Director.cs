using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private ICocktailBuilder _cocktailBuilder;

        public ICocktailBuilder cocktailBuilder
        {
            set { _cocktailBuilder = value; }
        }

        public void buildMojito()
        {
            _cocktailBuilder.AddWhiteRome();
            _cocktailBuilder.AddMint();
            _cocktailBuilder.AddSoda();
            _cocktailBuilder.AddSugar();
        }

        public void buildDaiquiri(bool strawberry = false)
        {
            _cocktailBuilder.AddWhiteRome();
            _cocktailBuilder.AddSugar();
            _cocktailBuilder.AddLime();
            if (strawberry) _cocktailBuilder.AddStrawberry();
        }

        public void buildPinaColada()
        {
            _cocktailBuilder.AddWhiteRome();
            _cocktailBuilder.AddPineapple();
            _cocktailBuilder.AddSoda();
            _cocktailBuilder.AddCreamyCoconut();
            _cocktailBuilder.AddSalt();
        }

        public void buildMartini()
        {
            _cocktailBuilder.AddGin();
            _cocktailBuilder.AddVermouth();
            _cocktailBuilder.AddLemon();
        }
    }
}
