using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> estacionamento = new List<string>();

            Console.WriteLine("Bem-vindo ao Conradito Parking Lots");
            while (true)
            {
                Console.WriteLine("Por favor, escolha uma opção: ");
                Console.WriteLine("1 - Estacionar");
                Console.WriteLine("2 - Retirar veículo");
                Console.WriteLine("3 - Listar veículos");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Digite a placa do veículo a ser estacionado:");
                    string placa = Console.ReadLine().ToUpper();

                    if (placa.Length != 6)
                    {
                        Console.WriteLine("Placa inválida! A placa deve ter exatamente 6 caracteres.");
                    }
                    else if (estacionamento.Contains(placa))
                    {
                        Console.WriteLine("Veículo com a placa {0} já está estacionado.", placa);
                    }
                    else
                    {
                        estacionamento.Add(placa);
                        Console.WriteLine($"Veículo com a placa {placa} estacionado com sucesso!");
                    }
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Digite a placa do veículo a ser retirado:");
                    string placa = Console.ReadLine().ToUpper();

                    if (estacionamento.Contains(placa))
                    {
                        estacionamento.Remove(placa);
                        Console.WriteLine($"Veículo com a placa {placa} foi retirado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Veículo com a placa {0} não está estacionado.", placa);
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Veículos estacionados:");

                    if (estacionamento.Count == 0)
                    {
                        Console.WriteLine("[_____]");
                    }
                    else
                    {
                        string placas = "[" + estacionamento[0] + "]";
                        for (int estacionamento2 = 1; estacionamento2 < estacionamento.Count; estacionamento2++)
                        {
                            placas += " [" + estacionamento[estacionamento2] + "]";
                        }
                        Console.WriteLine(placas);
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
                }














            
            }
        }
    }
}
