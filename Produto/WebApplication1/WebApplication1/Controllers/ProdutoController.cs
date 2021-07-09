using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id = 0)
        {
            try
            {
                if (id != 0)
                {
                    return Ok(_produtoRepositorio.ObterPorId(id));
                }
                else
                {
                    return Ok(_produtoRepositorio.ObterTodos());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        // POST api/<ProdutoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Produto produto)
        {
            try
            {
                if (id != produto.Id) return BadRequest("O id é diferente do id produto");
                _produtoRepositorio.Atualizar(produto);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
               var produto = _produtoRepositorio.ObterPorId(id);
                _produtoRepositorio.Remover(produto);
                return Ok("Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}