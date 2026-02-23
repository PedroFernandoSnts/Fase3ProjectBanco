using System;

public class TransacaoTed : Transacao
{
    public string Finalidade { get; set; }

    public override void Validar()
    {
        Console.WriteLine("Validando transação TED...");
        if (string.IsNullOrEmpty(Finalidade))
        {
            Console.WriteLine("Finalidade da TED não informada!");
        }
        else
        {
            Console.WriteLine("TED validada com sucesso.");
        }
    }
}
