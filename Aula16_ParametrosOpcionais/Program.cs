using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16_ParametrosOpcionais
{

    public class CaixaDialogo
    {
        public void Show(string Mensagem, bool ok, bool No, bool Cancel = false, int Delay = 10)
        {
            Console.WriteLine(Mensagem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dlg1 = new CaixaDialogo();
            dlg1.Show("Confirmar?", true, true);

            var dlg2 = new CaixaDialogo();
            dlg2.Show("Excluir?", true, true);

            Console.ReadKey();
        }
    }
}
