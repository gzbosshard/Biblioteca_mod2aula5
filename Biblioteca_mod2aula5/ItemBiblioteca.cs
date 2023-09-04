using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_mod2aula5
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }

        public ItemBiblioteca(string titulo, string autor, int anoPublicacao, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            NumeroPaginas = numeroPaginas;
        }
    }
}
