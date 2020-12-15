using System;
using MetodosConstrutores.Classe;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(0000000000, "Hot-Dog", "Hot-Dog feito com muito capricho.\r\nNele vai ourê, batata, maionese e o que mais você desejar.", 15);
        }
    }
}
