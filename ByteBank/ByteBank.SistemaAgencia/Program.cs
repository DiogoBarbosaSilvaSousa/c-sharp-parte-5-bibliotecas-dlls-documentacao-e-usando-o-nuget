using Humanizer;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //ContaCorrente conta = new ContaCorrente(847, 489754);

            //  Console.WriteLine(conta.Numero);

            TesteDePacoteDoNuget();

            Console.ReadLine();
        }

        public static void TesteDePacoteDoNuget()
        {
            DateTime dataFimPagamento = new DateTime(2021, 8, 22);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);
        }
    }
}
