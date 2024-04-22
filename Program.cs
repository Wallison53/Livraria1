namespace Trabalho1;

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro("Livro Pica-Pau", "Autor Luois moin", "523456789", 10);
        LivroDigital livroDigital1 = new LivroDigital("Livro Digital Batman", "Autor Lucas Pob", "987654321", 5, "PDF");

        livro1.AdicionarEstoque(10);
        livro1.Vender(3);

        livroDigital1.AdicionarEstoque(3);
        livroDigital1.Vender(4);

        Console.WriteLine("Estado atual do estoque do Livro Pica-Pau: " + livro1.QuantidadeEmEstoque);
        Console.WriteLine("Estado atual do estoque do Livro Digital Batman: " + livroDigital1.QuantidadeEmEstoque);
    }
}