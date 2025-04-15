using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entities
{
    internal class Usuarios
    {
        public string Nome {  get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAcesso { get; set; }
    }
}
