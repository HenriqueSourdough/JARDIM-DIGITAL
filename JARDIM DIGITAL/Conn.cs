using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARDIM_DIGITAL
{
    internal class Conn
    {
        private const string servidor = "127.0.0.1"; // locahost ou 127.0.0.1
        private const string bancoDados = "jardimdigital";
        private const string usuario = "root";
        private const string senha = "";

        public static string conn = $"server={servidor};user={usuario};password={senha};database={bancoDados}";
    }
}
