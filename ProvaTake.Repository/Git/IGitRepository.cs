using ProvaTake.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProvaTake.Repository.Git
{
    public interface IGitRepository
    {
        Task<RespostaRepositorios> Top5ProjetosGitTakeAsync();

    }
}
