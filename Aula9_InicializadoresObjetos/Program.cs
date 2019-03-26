using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_InicializadoresObjetos
{
    public class Filme
    {
        public string Nome;
        public int Ano;
    }

    public class Ator
    {
        public int Codigo;
        public string Nome;
        public List<Filme> Filmes;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ator a = new Ator()
            {
                Codigo = 10,
                Nome = "Michael",
                Filmes = new List<Filme>()
                {
                    new Filme() { Nome = "Prison Break"},
                    new Filme() { Nome = "Programa", Ano = 2013}
                }
            };


        }
    }
}
