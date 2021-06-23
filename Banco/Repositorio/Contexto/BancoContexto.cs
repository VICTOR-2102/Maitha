using Domínio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Contexto
{
  public  class BancoContexto : DbContext
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Contato> Contatos { get; set; }
        DbSet<Agencia> Agencias { get; set; }
        DbSet<Conta> Contas { get; set; }

        public BancoContexto(DbContextOptions options) : base (options)
        {

        }

    }
}
