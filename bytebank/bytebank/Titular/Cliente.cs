﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        public static int TotalDeClientes { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente()
        {
            TotalDeClientes++;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O cliente {Nome} tem o CPF {Cpf} e tem como profissão {Profissao}.");
        }
    }
}
