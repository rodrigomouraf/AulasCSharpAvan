using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_ParametrosNomeados
{
    public class Dialogo
    {
        public void Show(DialogoParms parametros)
        {
            Console.WriteLine(parametros.Mensagem);
        }
    }

    public class DialogoParms
    {
        public string Mensagem = "lalalala";
        public bool MostratBotaoOk;
        public bool MostratBotaoNo;
        public bool MostratBotaoCancel;
        public int Delay;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var parametros = new DialogoParms()
            {
                Mensagem = "Confirmação operação"
                ,MostratBotaoOk = true
                ,Delay = 10
                ,MostratBotaoNo = true 
                ,MostratBotaoCancel = false

            };

            var dlg2 = new Dialogo();
            dlg2.Show(parametros);

            Console.ReadKey();
        }
    }
}
