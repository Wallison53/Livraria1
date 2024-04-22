public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string titulo, string autor, string isbn, int quantidadeEmEstoque)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        QuantidadeEmEstoque += quantidade;
    }

    public void Vender(int quantidade)
    {
        if (QuantidadeEmEstoque >= quantidade)
        {
            QuantidadeEmEstoque -= quantidade;
        }
        else
        {
            Console.WriteLine("Estoque insuficiente para realizar a venda.");
        }
    }
}