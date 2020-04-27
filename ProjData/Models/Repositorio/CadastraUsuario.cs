using MySql.Data.MySqlClient;
using ProjData.Models.DadosTabela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjData.Models.Repositorio
{
    public class CadastraUsuario
    {
        Conexao conexao = new Conexao();
        public bool insertCadastro(Usuario usuario)
        {
            try
            {
                MySqlCommand select = new MySqlCommand("select * from tbLogin where login = @loguin", conexao.MyConectarBD());
                select.Parameters.Add("@loguin", MySqlDbType.VarChar).Value = usuario.Login.Loguin;
                MySqlDataReader read = select.ExecuteReader();

                if (read.Read())
                {
                    read.Close();
                    conexao.MyDesconectarBD();
                    return false;
                }
                else
                {
                    read.Close();
                    conexao.MyDesconectarBD();
                    MySqlCommand my = new MySqlCommand("call insertTbUsuario(@nome,@sobrenome,@loguin,@senha,@renda)", conexao.MyConectarBD());

                    my.Parameters.Add("@nome", MySqlDbType.VarChar).Value = usuario.Nomeuser;
                    my.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = usuario.Sobrenomeuser;
                    my.Parameters.Add("@loguin", MySqlDbType.VarChar).Value = usuario.Login.Loguin;
                    my.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Login.Senha;
                    my.Parameters.Add("@renda", MySqlDbType.Decimal).Value = usuario.Login.Senha;

                    my.ExecuteNonQuery();
                    conexao.MyDesconectarBD();
                    return true;
                }
            }
            catch (Exception e)
            {
                string erro = e.ToString();
                throw;
            }

        }
    }
}