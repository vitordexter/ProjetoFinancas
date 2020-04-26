using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjData.Models.DadosTabela
{
    public class Descricao
    {
        private string codDesc;
        private string datac;
        private string descr;
        private string loja;
        private string categoria;
        private string necessidade;
        private string tipo;
        private string forma_pgto;
        private double preco;

        public string Descr { get => descr; set => descr = value; }
        public string CodDesc { get => codDesc; set => codDesc = value; }
        public string Loja { get => loja; set => loja = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Necessidade { get => necessidade; set => necessidade = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Forma_pgto { get => forma_pgto; set => forma_pgto = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Datac { get => datac; set => datac = value; }
    }
}