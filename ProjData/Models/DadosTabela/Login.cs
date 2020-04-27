using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjData.Models.DadosTabela
{
    public class Login
    {
        private string loguin;
        private string senha;
        private string codLogin;

        public string Loguin { get => loguin; set => loguin = value; }
        public string Senha { get => senha; set => senha = value; }
        public string CodLogin { get => codLogin; set => codLogin = value; }

    }
}