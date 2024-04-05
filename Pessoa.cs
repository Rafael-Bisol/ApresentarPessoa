using System;

public class Pessoa
{
    public string Nome {get; set;}
    public int Idade {get; set;}
    public double Altura {get; set;}

    public Pessoa(string nome, int idade, double altura)
    {
        // Não era necessário colocar 'this.' mas pus para não esquecer que existe
        this.Nome = nome;
        this.Idade = idade;
        this.Altura = altura;
    }

    public void Apresentar()
    {
        Console.WriteLine($"A pessoa que se chama {Nome}, tem {Idade} anos e {Altura} de altura");
    }
}