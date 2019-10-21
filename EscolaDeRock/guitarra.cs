using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.models
{
    public class Guitarra : InstrumentoMusical,Imelodia, IHarmonia;
    {
        public bool TocarAcordes()
        {
            Console.Writeline("tocando acordes da guitarra. ");
            return true;
        }
    }
}

    
