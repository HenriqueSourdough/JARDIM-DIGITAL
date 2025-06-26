using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JARDIM_DIGITAL
{
    public static class Seguranca
    {
        public static string GerarHashSHA1(string texto)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha1.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
