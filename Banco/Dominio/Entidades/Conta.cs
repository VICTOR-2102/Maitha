using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Entidades
{
    public class Conta : Base
    {
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int AgenciaId { get; set; }
        public virtual Agencia Agencia { get; set; }
        public string Tipo { get; set; }
        public int NrConta { get; set; }
        public decimal  Saldos { get; set; }
    }
}
