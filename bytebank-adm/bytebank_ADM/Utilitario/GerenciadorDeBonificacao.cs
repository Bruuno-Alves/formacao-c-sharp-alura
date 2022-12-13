using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    internal class GerenciadorDeBonificacao
    {
        public double Bonificacoes { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.Bonificacoes += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.Bonificacoes += diretor.GetBonificacao();
        }
    }
}
