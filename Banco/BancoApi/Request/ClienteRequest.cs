using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoApi.Request
{
    public class ClienteRequest
    {
        public string Documento { get; set; }
        public DateTime DataDeNascimento  { get; set; }
    }
}
