using System;

public class Transacao
{
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public ContaBancaria Origem { get; set; }
    public ContaBancaria Destino { get; set; }

    public virtual void Validar()
    {
        Console.WriteLine("Validando transação padrão...");
    }
}
