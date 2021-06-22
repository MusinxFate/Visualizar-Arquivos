using System;
using System.IO;

namespace Visualizar_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
        tentarNovamente:
            Console.Clear();
            Console.WriteLine("Insira o diretório desejado para visualização dos arquivos:");
            var diretorio = Console.ReadLine();
            if (diretorio.Length <= 0)
                goto tentarNovamente;
            else
            {
                try
                {
                    Console.Clear();
                    var arquivos = Directory.GetFiles(diretorio);
                    foreach (var arquivo in arquivos)
                    {
                        Console.WriteLine(arquivo);
                    }
                }
                catch
                {
                tentarNovamente2:
                    Console.WriteLine("\r\nNão foi possível encontrar o diretório especificado, deseja tentar novamente? (S/N)");
                    var resposta = Console.ReadLine();
                    if (resposta.Length != 1)
                    {
                        Console.WriteLine("Por favor, insira \"S\" para Sim ou \"N\" para Não");
                        goto tentarNovamente2;
                    }
                    else
                    {
                        if (resposta.ToLower() == "s")
                            goto tentarNovamente;
                        else if (resposta.ToLower() == "n")
                            return;
                        else
                        {
                            Console.WriteLine("Resposta Inválida\r");
                            goto tentarNovamente2;
                        }
                    }
                }
            }
        }
    }
}
