using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API2.Domains;
using API2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        // 01 - Instanciamos nosso repositório para manipular nosso banco
        AlunoRepository repo = new AlunoRepository();

        // GET: api/<AlunoController>
        [HttpGet]
        public List<Aluno> Get()
        {
            // 02 - Chamamos nosso método do repositório
            return repo.LerTodos();
        }

        // GET: api/Aluno/5
        [HttpGet("{id}", Name = "Get")]
        public Aluno Get(int id)
        {
            return repo.BuscarPorId(id);
        }

        // POST: api/Aluno
        [HttpPost]
        public Aluno Post([FromBody] Aluno a)
        {
            return repo.Cadastrar(a);
        }

        // PUT: api/Aluno/5
        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] Aluno a)
        {
            return repo.Alterar(id, a);
        }

            
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}
