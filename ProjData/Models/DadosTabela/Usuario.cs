using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjData.Models.DadosTabela
{
    public class Usuario
    {
        private string coduser;
        private string nomeuser;
        private string sobrenomeuser;
        private string renda;
        private string codLogin;
        private Login login;


        public string Coduser { get => coduser; set => coduser = value; }
        public string Nomeuser { get => nomeuser; set => nomeuser = value; }
        public string Renda { get => renda; set => renda = value; }
        public string Sobrenomeuser { get => sobrenomeuser; set => sobrenomeuser = value; }
        public Login Login { get => login; set => login = value; }
        public string CodLogin { get => codLogin; set => codLogin = value; }
    }
}