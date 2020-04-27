using MySql.Data.MySqlClient;
using ProjData.Models.DadosTabela;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjData.Models.Repositorio
{
    public class clTesteLogin
    {
        Conexao conexao = new Conexao();
        UserLogado userLogado = new UserLogado();

        public UserLogado testeLogin(Login login)
        {
            try
            {
                MySqlCommand select = new MySqlCommand("select * from tbLogin l inner join tbUsuario u on u.email = @loguin " +
                    "                                   and u.codLogin_FK = l.codLogin", conexao.MyConectarBD());
                select.Parameters.Add("@loguin", MySqlDbType.VarChar).Value = login.Loguin;

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(select);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    userLogado.Login1 = new Login();
                    userLogado.Usuario = new Usuario();

                    userLogado.Login1.CodLogin = dt.Rows[0][0].ToString();
                    userLogado.Login1.Loguin = dt.Rows[0][1].ToString();
                    userLogado.Login1.Senha = dt.Rows[0][2].ToString();
                    userLogado.Usuario.Coduser = dt.Rows[0][3].ToString();
                    userLogado.Usuario.Nomeuser = dt.Rows[0][4].ToString();
                    userLogado.Usuario.Sobrenomeuser = dt.Rows[0][5].ToString();
                    userLogado.Login1.Loguin = dt.Rows[0][6].ToString();
                    userLogado.Login1.Senha = dt.Rows[0][7].ToString();
                    userLogado.Usuario.Renda = dt.Rows[0][8].ToString();
  
                    conexao.MyDesconectarBD();
                    return userLogado;
                }
                return null;
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}