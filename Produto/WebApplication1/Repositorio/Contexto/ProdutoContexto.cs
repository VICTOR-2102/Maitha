using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Repositorio.Config
{   
   public class ProdutoContexto : DbContext
    {
        DbSet<Produto> Produtos { get; set; }
        public ProdutoContexto(DbContextOptions options) : base(options)
        { }
    }
}
