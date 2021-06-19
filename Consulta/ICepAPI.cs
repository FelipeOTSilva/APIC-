using Refit;
using System.Threading.Tasks;
namespace Consulta
{
    public interface ICepAPI
    {
        [Get ("/ws/{cep}/json")]
        Task<CEPClass> GetAddressASync(string cep);
    }
}
