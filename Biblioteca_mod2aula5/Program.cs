namespace Biblioteca_mod2aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new();

            biblioteca.AdicionarItem(new Livro("titulo1", "autor1", 2015, 100, new DateTime(2023,08,05).Date));
            biblioteca.AdicionarItem(new MidiaDigital("midia1", "autor3", 2020, 10, new DateTime(2022,06,17).Date));
            biblioteca.AdicionarItem(new Revista("revista1", "autor2", 2020, 25, new DateTime(2021,04,13).Date));

            biblioteca.EmprestarBiblioteca(biblioteca.ListaItens[2]);
            biblioteca.DevolverBiblioteca(biblioteca.ListaItens[2]);
            
        }
    }
}