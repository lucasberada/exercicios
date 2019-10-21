using System;

namespace EscolaDeRock
{
   public class InstrumentoMusical
    {
        string[] notas ={"do","re","mi","fa","so","la","si","do"};
        public string TocarMusica()
        {
            int nota = new Random().Next(notas.Length -1);
            return notas[nota];
        }
        
    }
} 