using System.ComponentModel;

int Numero;

Console.Write("Digite um numero...: ");
Numero = Convert.ToInt32(Console.ReadLine());

if (Numero < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você digitou um número negativo.");
    }

Console.ResetColor();