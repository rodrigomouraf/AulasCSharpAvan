using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_ClassesParciais
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario(123,"Rodrigo","senha");
            if (user.Autenticar())
                Console.WriteLine("Usuario autenticado com sucesso");
            else
                Console.WriteLine("Credenciais invalidas");

            Console.ReadKey();
        }
    }
}
