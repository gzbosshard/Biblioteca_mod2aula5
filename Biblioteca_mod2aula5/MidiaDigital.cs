using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_mod2aula5
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public DateTime DataEmprestimo { get; set; }

        public MidiaDigital(string titulo, string autor, int anoPublicacao, int numeroPaginas, DateTime dataEmprestimo) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
            DataEmprestimo = dataEmprestimo;
        }

        public void Devolver()
        {
            Console.WriteLine($"{Environment.NewLine}----- Devolução: -----{Environment.NewLine}");
            Console.WriteLine($"{Environment.NewLine}\u001b[32mA mídia digital foi devolvida\u001b[0m");
        }

        public void Emprestar()
        {
            Console.WriteLine($"A mídia digital está sendo emprestado em {DataEmprestimo.Date} e não há prazo para devolução{Environment.NewLine}");
            Console.WriteLine($"{Environment.NewLine}----- Informações sobre a mídia digital: ------{Environment.NewLine}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor} | Ano de Publicação: {AnoPublicacao} | Número de Páginas: {NumeroPaginas}");

        }
    }
}
