using Domínio.Entidades;
using Domínio.Interfaces;
using Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
   public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(BancoContexto bancoContexto) : base(bancoContexto) { }
    }
    
}
