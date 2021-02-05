using Octokit;
using ProvaTake.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTake.Repository.Git
{
    public class GitRepository : IGitRepository
    {
        private const string PRODUCT_HEADER = "ProvaTake";
        private readonly GitHubClient _client;
        public GitRepository()
        {            
            _client = new GitHubClient(new ProductHeaderValue(PRODUCT_HEADER));
        }
        /// <summary>
        /// Método que consulta a API do GitHub para recuperar as informações do perfil e dos repositorios da Take
        /// </summary>
        /// <returns></returns>
        public async Task<Repositorio> Top5ProjetosGitTakeAsync()
        {
            const string LINGUAGEM = "C#";
            const string TIPO_DOCUMENTO = "application / vnd.lime.document - select + json";
            const string TIPO_HEADER = "application/vnd.lime.media-link+json";
            const string TIPO_IMAGEM = "image/jpeg";

            var user = await _client.User.Get("takenet");
            var repositorios = await _client.Repository.GetAllForUser(user.Login);

            var repositoriosCSharp = repositorios
                                        .Where(i => i.Language == LINGUAGEM)
                                        .OrderBy(i => i.CreatedAt)
                                        .Take(5);

            var listaRespositorios = new Repositorio()
            {
                ItemType = TIPO_DOCUMENTO,
                Items = repositoriosCSharp.Select(r => new Item()
                {
                    Header = new Header()
                    {
                        Type = TIPO_HEADER,
                        Value = new HeaderValue()
                        {
                            Type = TIPO_IMAGEM,
                            Text = r.Description,
                            Title = r.FullName,
                            Uri = new System.Uri(user.AvatarUrl)
                        }
                    }
                }).ToArray()
            };

            return listaRespositorios;
        }
    }
}
