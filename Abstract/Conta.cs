using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Conta
    {
        public double Saldo { get; set; }

        //assinatura método abstrato
        public abstract void ImprimeExtratoDetalhado();
    }
}
