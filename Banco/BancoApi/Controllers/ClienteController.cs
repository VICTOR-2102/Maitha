using BancoApi.Request;
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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IContatoRepositorio _contatoRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio, IContatoRepositorio contatoRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
            _contatoRepositorio = contatoRepositorio;
        }
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id = 0)
        {
            try
            {
                if (id != 0)
                {
                    return Ok(_clienteRepositorio.ObterPorId((int)id));
                }
                else
                {
                    return Ok(_clienteRepositorio.ObterTodos());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepositorio.Adicionar(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Cliente cliente)
        {
            try
            {
                if (id != cliente.Id) return BadRequest("O id é diferente do id cliente");
                _clienteRepositorio.Atualizar(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepositorio.Remover(cliente);
                return Ok("Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("ClientePorDocumento")]
        public async Task<IActionResult> ClientePorDocumento([FromBody] ClienteRequest cliente)
        {
            return Ok(new Cliente());
        }

        [HttpGet("Contato/ClienteId/{id}")]
        public async Task<IActionResult> GetContatoClienteId(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound("Id do cliente não informado!");
                else
                    return Ok(_contatoRepositorio.ObterTodos().Where(contato => contato.ClienteId == id).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet("Contato/{id?}")]
        public async Task<IActionResult> GetContato(int id = 0)
        {
            try
            {
                if (id != 0)
                    return Ok(_contatoRepositorio.ObterPorId(id));

                return Ok(_contatoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }

}
