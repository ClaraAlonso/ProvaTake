using Octokit;
using ProvaTake.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTake.Repository.Git
{
    public class GitRepository : IGitRepository
    {
        private readonly GitHubClient _client;
        public GitRepository()
        {
            _client = new GitHubClient(new ProductHeaderValue("ProvaTake"));
        }

        public async Task<RespostaRepositorios> Top5ProjetosGitTakeAsync()
        {
            var user = await _client.User.Get("takenet");
            var repositorios = await _client.Repository.GetAllForUser(user.Login);

            var repositoriosCSharp = repositorios
                                        .Where(i => i.Language == "C#")
                                        .OrderBy(i => i.CreatedAt)
                                        .Take(5);

            var listaRespositorio = repositoriosCSharp
                                        .Select(r => new Repositorio() 
                                        { 
                                            Nome = r.FullName, 
                                            Descricao = r.Description 
                                        });

            return new RespostaRepositorios()
            {
                UrlAvatar = user.AvatarUrl, 
                Repositorios = listaRespositorio
            };
        }
    }
}
