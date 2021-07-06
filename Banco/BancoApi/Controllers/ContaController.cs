using Domínio.Entidades;
using Domínio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaRepositorio _contaRepositorio;
        public ContaController(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id = 0)
        {
            try
            {
                if (id != 0)
                {
                    return Ok(_contaRepositorio.ObterPorId((int)id));
                }
                else
                {
                    return Ok(_contaRepositorio.ObterTodos());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Conta conta)
        {
            try
            {
                _contaRepositorio.Adicionar(conta);
                return Ok(conta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Conta conta)
        {
            try
            {
                if (id != conta.Id) return BadRequest("O id é diferente do id cliente");
                _contaRepositorio.Atualizar(conta);
                return Ok(conta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
       // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromBody] Conta conta)
        {
            try
            {
                _contaRepositorio.Remover(conta);
                return Ok("Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
