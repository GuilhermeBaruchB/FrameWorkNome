using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("O nome digite foi: " + nome);

            Console.ReadKey();
        }
    }
}
