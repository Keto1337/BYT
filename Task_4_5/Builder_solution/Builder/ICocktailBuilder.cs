using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICocktailBuilder
    {
        void AddWhiteRome();
        void AddSugar();
        void AddSalt();
        void AddLime();
        void AddMint();
        void AddSoda();
        void AddCreamyCoconut();
        void AddPineapple();
        void AddStrawberry();
        void AddVodka();
        void AddGin();
        void AddVermouth();
        void AddLemon();

    }
}
