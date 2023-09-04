using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_mod2aula5
{
    public class Biblioteca
    {
        
        public List<ItemBiblioteca> ListaItens = new List<ItemBiblioteca>();

        public void AdicionarItem(ItemBiblioteca item)
        {
            ListaItens.Add(item);
        }

        public void EmprestarBiblioteca(ItemBiblioteca item)
        {
            if (item is IPodeSerEmprestado itemEmprestimo)
            {
                itemEmprestimo.Emprestar();
            }
            else
            {
                Console.WriteLine("Este item não pode ser emprestado.");
            }
        }

        public void DevolverBiblioteca(ItemBiblioteca item)
        {
            if (item is IPodeSerEmprestado itemEmprestimo)
            {
                itemEmprestimo.Devolver();
            }
            else
            {
                Console.WriteLine("Este item não pode ser devolvido.");
            }
        }
    }
}
