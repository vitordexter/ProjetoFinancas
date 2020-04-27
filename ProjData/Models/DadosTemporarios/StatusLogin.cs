using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjData.Models.DadosTemporarios
{
    public class StatusLogin
    {
        private bool statusDoLogin;

        public bool StatusDoLogin { get => statusDoLogin; set => statusDoLogin = value; }
    }
}