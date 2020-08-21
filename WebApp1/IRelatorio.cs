using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApp1
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}