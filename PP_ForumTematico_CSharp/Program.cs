using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_ForumTematico_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeusuario;
            
            Console.WriteLine("Hello World");
            Console.WriteLine("Digite seu nome");

            nomeusuario = Console.ReadLine();
            Console.WriteLine("Olá " + nomeusuario);

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
