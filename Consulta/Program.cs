using Refit;
using System;
using System.Threading.Tasks;

namespace Consulta
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try 
            {
                var cep = RestService.For<ICepAPI>("https://viacep.com.br/");
                Console.WriteLine("Informe seu CEP:");

                string CepInformado = Console.ReadLine().ToString();

                var Consulta = await cep.GetAddressASync(CepInformado);

                Console.WriteLine($"\n Endereço:{Consulta.Logradouro} \n Complemento: {Consulta.Complemento} \n Bairro:{Consulta.Bairro} " +
                    $"\n Cidade:{Consulta.Localidade} \n Estado: {Consulta.UF}");
                Console.ReadKey();
            
            } catch { Exception e; }
            {
                Console.WriteLine("Erro na consulta do CEP!");
            }
        }
    }
}
