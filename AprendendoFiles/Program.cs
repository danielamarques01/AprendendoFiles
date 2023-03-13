using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARQUIVOS DE TEXTO


            //StreamWriter escritor = File.AppendText("teste.txt"); (vai adicionar novas informações SEM remover as anteriores)

            /*StreamWriter escritor = new StreamWriter("teste.txt"); //StreamWriter = fluxo de gravação
                escritor.WriteLine("daniela");
                escritor.WriteLine("marques");
                escritor.WriteLine("Curso de c#");
                escritor.Close(); // para fechar o fluxo 
                Console.WriteLine("Arquivo gerado");
                Console.ReadLine();*/

            StreamReader leitor = new StreamReader("teste.txt");
            string conteudo = leitor.ReadToEnd();
            
            Console.WriteLine(conteudo);
            Console.WriteLine("Arquvio gerado");

        }
    }
}
