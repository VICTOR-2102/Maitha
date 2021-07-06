using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domínio.Entidades
{
   public class Contato : Base
    {
       
        public int ClienteId { get; set; }
        public string TipoContato { get; set; }
        public string Telefone { get; set; }
        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }


    }
}
