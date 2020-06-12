using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem argumentos
            Produto sapato = new Produto();

            //Um argumento
            Produto chinelo = new Produto(141596);
            System.Console.WriteLine("Código do chinelo: "+chinelo.Codigo);

            System.Console.WriteLine();

            //Todos os atributos
            Produto tenis = new Produto(951753, "All Star", "Vermelho", 98);
            System.Console.WriteLine("Código do Tênis: "+tenis.Codigo);
            System.Console.WriteLine("Marca do Tênis: "+tenis.Nome);
            System.Console.WriteLine("Descrição do Tênis: "+tenis.Descricao);
            System.Console.WriteLine("Código do Tênis: "+tenis.Estoque);

        }
    }
}
