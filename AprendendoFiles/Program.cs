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
            //string conteudo = leitor.ReadToEnd(); (ele armazena todo o conteudo em uma unica string, vai imprimir tudo de uma vez)
            //Console.WriteLine(conteudo);

            /*Console.WriteLine(leitor.ReadLine()); //aqui aparece linha por linha 
            Console.WriteLine(leitor.ReadLine());
            Console.WriteLine(leitor.ReadLine());*/

            List<string> linhas = new List<string>();
            string linha = ""; //aqui aparece linha por linha 

            while (linha != null)
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    //Console.WriteLine(linha);
                    linhas.Add(linha);// cada linha separada no arquivo está adicionando dentro da lista
                }
            }

            Console.WriteLine(linhas[0]);

            /*foreach(string nome in linhas)
            {
                Console.WriteLine(nome);
            }*/
            Console.WriteLine("Arquvio gerado");

        }
    }
}
