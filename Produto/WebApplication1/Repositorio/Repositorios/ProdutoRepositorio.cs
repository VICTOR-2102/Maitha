using Dominio;
using Dominio.Interfaces;
using Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Repositorios
{
   public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ProdutoContexto produtoContexto) : base(produtoContexto) { }
    }
}
