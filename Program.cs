using System;

class Program
{
    public void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo!");
        Pessoa pessoa = new Pessoa("Velho Chato", 1000, 1.75);
        pessoa.Apresentar();
    }
}