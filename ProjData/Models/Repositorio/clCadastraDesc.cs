using MySql.Data.MySqlClient;
using ProjData.Models.DadosTabela;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjData.Models.Repositorio
{
    public class clCadastraDesc
    {
        Conexao conexao = new Conexao();
        public bool insertCadastro(Descricao descricao)
        {
            try
            {
                MySqlCommand my = new MySqlCommand("insert into tbDados (datac,Descr,loja,tipo,categ,nece,forma_pgto,preco,codusuario) values (@data,@desc,@loja,@tipo,@categoria,@necessidade," +
                    "@formapgto,@preco,@codCli)", conexao.MyConectarBD());

                my.Parameters.Add("@data", MySqlDbType.VarChar).Value = descricao.Datac;
                my.Parameters.Add("@desc", MySqlDbType.VarChar).Value = descricao.Descr;
                my.Parameters.Add("@loja", MySqlDbType.VarChar).Value = descricao.Loja;
                my.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = descricao.Tipo;
                my.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = descricao.Categoria;
                my.Parameters.Add("@necessidade", MySqlDbType.VarChar).Value = descricao.Necessidade;
                my.Parameters.Add("@formapgto", MySqlDbType.VarChar).Value = descricao.Forma_pgto;
                my.Parameters.Add("@preco", MySqlDbType.Decimal).Value = descricao.Preco;
                my.Parameters.Add("@codCli", MySqlDbType.VarChar).Value = descricao.Coduser;
                my.ExecuteNonQuery();
                conexao.MyDesconectarBD();
                return true;
            }
            catch (Exception e)
            {
                string erro = e.ToString();
                throw;
            }

        }
    }
}