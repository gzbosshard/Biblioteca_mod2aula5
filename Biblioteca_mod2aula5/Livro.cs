using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_mod2aula5
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public DateTime DataEmprestimo { get; set; }
        public int PrazoDevolucao = 20;
        public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas, DateTime dataEmprestimo) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
            DataEmprestimo = dataEmprestimo.Date;
        }

        public void Devolver()
        {
            Console.WriteLine($"{Environment.NewLine}----- Devolução: -----{Environment.NewLine}");
            Console.Write("Data de devolução: ");
            DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());

            if (dataDevolucao > DataEmprestimo.Date.AddDays(PrazoDevolucao))
            {
                Console.WriteLine($"\u001b[31m{Environment.NewLine}Devolução feita com atraso\u001b[0m");
            }
            else
            {
                Console.WriteLine($"\u001b[32m{Environment.NewLine}O livro {Titulo} foi devolvido dentro do prazo\u001b[30m");
            }
        }

        public void Emprestar()
        {
            Console.WriteLine($"O livro está sendo emprestado em {DataEmprestimo.Date} e deve ser devolvido até {DataEmprestimo.Date.AddDays(PrazoDevolucao)}");
            Console.WriteLine($"{ Environment.NewLine}----- Informações sobre o livro: -----{Environment.NewLine}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor} | Ano de Publicação: {AnoPublicacao} | Número de Páginas: {NumeroPaginas}");
        }
    }
}
