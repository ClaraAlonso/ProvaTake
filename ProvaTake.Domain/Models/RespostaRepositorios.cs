using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaTake.Domain.Models
{
    public class RespostaRepositorios
    {
        public string UrlAvatar { get; set; }    
        public IEnumerable<Repositorio> Repositorios { get; set; }    
    }
}
