﻿using Microsoft.AspNetCore.Mvc;
using ProvaTake.Domain.Models;
using ProvaTake.Repository.Git;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProvaTake.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitController : ControllerBase
    {

        private readonly IGitRepository _gitRepository;        

        public GitController(IGitRepository gitRepository)
        {
            _gitRepository = gitRepository;            
        }

        [HttpGet]
        public async Task<RespostaRepositorios> GetAsync()
        {
            return await _gitRepository.Top5ProjetosGitTakeAsync();
        }
    }
}
