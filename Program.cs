using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco
        {
            Nome = "Banco Central",
            CodigoBACEN = "001"
        };

        ContaBancaria conta1 = new ContaBancaria { Numero = "123", Banco = banco };
        ContaBancaria conta2 = new ContaBancaria { Numero = "456", Banco = banco };

        TransacaoPix pix = new TransacaoPix
        {
            Valor = 250,
            Data = DateTime.Now,
            Origem = conta1,
            Destino = conta2,
            ChavePix = "email@pix.com"
        };

        TransacaoTed ted = new TransacaoTed
        {
            Valor = 500,
            Data = DateTime.Now,
            Origem = conta1,
            Destino = conta2,
            Finalidade = "Pagamento de serviços"
        };

        List<Transacao> lista = new List<Transacao>();
        lista.Add(pix);
        lista.Add(ted);

        foreach (var t in lista)
        {
            t.Validar();
        }
    }
}
