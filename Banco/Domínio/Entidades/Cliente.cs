using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        public string Email { get; set; }
        public string CPFCNPJ { get; set; }
        public virtual List<Contato> Contatos { get; set; }


    }
}
