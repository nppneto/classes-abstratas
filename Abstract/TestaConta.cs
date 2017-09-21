using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class TestaConta
    {
        static void Main(string[] args)
        {
            //como a classe abstrata n pode ser instanciada, instanciamos através da conta-poupança, que é herdeira da classe conta
            Conta c = new ContaPoupanca();

            c.Saldo = 1000;
            
            c.ImprimeExtratoDetalhado();

            Console.ReadKey();
        }
    }
}
