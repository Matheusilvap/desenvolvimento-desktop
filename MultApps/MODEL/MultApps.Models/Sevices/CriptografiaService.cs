using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Sevices
{
    public class CriptografiaService
    {
        public string Criptografar(string senha)
        {
            var passwordHash = BCrypt.hashPassword("Password123!")
            return passwordHash;
        }

        public string Verificar(string senha, string senhaCriptografada)
        {

        }
    }
}
