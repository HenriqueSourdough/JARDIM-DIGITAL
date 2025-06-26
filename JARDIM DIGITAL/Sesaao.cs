using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARDIM_DIGITAL
{
    public static class Sesaao
    {
        // Variáveis privadas (campos)
        private static int _usuarioId;
        private static string _nomeUsuario;
        private static string _emailUsuario;
        private static string _senha;

        // Propriedades públicas (GET/SET)

        public static int UsuarioId
        {
            get { return _usuarioId; }
            set { _usuarioId = value; }
        }

        public static string NomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }

        public static string EmailUsuario
        {
            get { return _emailUsuario; }
            set { _emailUsuario = value; }
        }
        public static string SenhaUsuario
        {
            get { return _senha; }
            set { _senha = value; }
        }
    }
}