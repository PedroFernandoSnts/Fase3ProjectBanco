using System;

public class TransacaoPix : Transacao
{
    public string ChavePix { get; set; }

    public override void Validar()
    {
        Console.WriteLine("Validando transação PIX...");
        if (string.IsNullOrEmpty(ChavePix))
        {
            Console.WriteLine("Chave PIX inválida!");
        }
        else
        {
            Console.WriteLine("PIX validado com sucesso.");
        }
    }
}
