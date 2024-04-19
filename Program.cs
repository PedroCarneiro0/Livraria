﻿namespace Trabalho1;

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro("Livro Turma-Monica", "Autor Mauricio De Souza", "78423798", 10);
        LivroDigital livroDigital1 = new LivroDigital("Livro Digital Demolidor", "Autor Stan Lee", "74002737", 5, "PDF");

        livro1.AdicionarEstoque(9);
        livro1.Vender(3);

        livroDigital1.AdicionarEstoque(4);
        livroDigital1.Vender(3);

        Console.WriteLine("Estado atual do estoque do Livro TurmaMonica: " + livro1.QuantidadeEmEstoque);
        Console.WriteLine("Estado atual do estoque do Livro Digital Demolidor: " + livroDigital1.QuantidadeEmEstoque);
    }
}