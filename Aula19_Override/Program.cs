using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo mp3 = new Musica() { Nome = "lalala" };
            Arquivo doc = new DocumentoWord() { Nome = ".net " };
            Arquivo img = new Imagem() { Nome = "lelele" };

            Windows windows = new Windows();
            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);

            windows.Abrir(mp3);
            windows.Abrir(doc);
            windows.Abrir(img);

            Console.ReadKey();
        }
    }
}
