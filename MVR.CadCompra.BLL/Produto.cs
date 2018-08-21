using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MVR.CadCompra.DAL;

namespace MVR.CadCompra.BLL
{
    public class Produto
    {
        public const string SQL_OBTER = "Select * from TB_PRODUTO where Codigo = {0}";

        public const string SQL_INSERT =
            "insert into tb_produto (Descricao, Ativo, CodigoEntrada, CodigoSaida, CaminhoArquivoImagem) values ('{1}',{2}, '{3}', '{4}', '{5}')";

        public const string SQL_UPDATE =
            "Update tb_produto set Descricao = '{1}', Ativo = {2}, CodigoEntrada = '{3}', CodigoSaida = '{4}', CaminhoArquivoImagem = '{5}' where codigo = {0}";

        public const string SQL_SELECT = "Select * from tb_produto where 1=1";
        public const string SQL_IDREFRESH = "Select max(codigo) from tb_produto";
        protected DBManager _dbManager;

        public Produto()
        {
            _dbManager = new DBManager();
        }

        public Produto(int codigo)
            : this()
        {
            if (codigo > 0)
            {
                Codigo = codigo;
                _dbManager.Open();
                var drProduto = _dbManager.SelectData(string.Format(SQL_OBTER, Codigo.ToString()));
                ConvertThisProduto(drProduto);
                _dbManager.Close();
            }
        }


        public static List<Produto> Listar(Produto filtro)
        {
            var dbManager = new DBManager();
            dbManager.Open();

            var stbSelect = new StringBuilder(SQL_SELECT);


            if (filtro.Codigo > 0) stbSelect.AppendFormat(" and Codigo = {0}", filtro.Codigo);

            if (!string.IsNullOrEmpty(filtro.Descricao))
                stbSelect.AppendFormat(" and Descricao like '%{0}%'", filtro.Descricao);

            if (filtro.Ativo.HasValue)
                stbSelect.AppendFormat(" and Ativo = {0}", filtro.Ativo.Value ? "True" : "False");

            if (!string.IsNullOrEmpty(filtro.CodigoEntrada))
                stbSelect.AppendFormat(" and CodigoEntrada = '{0}'", filtro.CodigoEntrada);

            if (!string.IsNullOrEmpty(filtro.CodigoSaida))
                stbSelect.AppendFormat(" and CodigoSaida = '{0}'", filtro.CodigoSaida);


            var dr = dbManager.SelectData(stbSelect.ToString());
            var produtos = dbManager.CarregarLista(dr, ConvertProduto);

            dbManager.Close();
            return produtos;
        }

        private void ConvertThisProduto(IDataReader dr)
        {
            dr.Read();
            try
            {
                Codigo = Convert.ToInt32(dr["Codigo"]);
                Descricao = dr["Descricao"].ToString();
                Ativo = Convert.ToBoolean(dr["Ativo"]);
                CodigoEntrada = dr["CodigoEntrada"].ToString();
                CodigoSaida = dr["CodigoSaida"].ToString();
                CaminhoArquivoImagem = dr["CaminhoArquivoImagem"].ToString();
            }
            catch (Exception ex)
            {
                throw new NotFoundException(ex);
            }
        }

        public static Produto ConvertProduto(IDataReader dr)
        {
            var p = new Produto();
            p.Codigo = Convert.ToInt32(dr["Codigo"]);
            p.Descricao = dr["Descricao"].ToString();
            p.Ativo = Convert.ToBoolean(dr["Ativo"]);
            p.CodigoEntrada = dr["CodigoEntrada"].ToString();
            p.CodigoSaida = dr["CodigoSaida"].ToString();
            p.CaminhoArquivoImagem = dr["CaminhoArquivoImagem"].ToString();
            return p;
        }

        public void Salvar()
        {
            Validar();
            _dbManager.Open();

            var sql = new StringBuilder();
            string sqlCommand;
            if (Codigo > 0)
                sqlCommand = SQL_UPDATE;
            else
                sqlCommand = SQL_INSERT;

            sql.AppendFormat(sqlCommand, Codigo.ToString(), Descricao, Ativo.ToString(), CodigoEntrada, CodigoSaida,
                CaminhoArquivoImagem);
            _dbManager.ExecuteSql(sql.ToString());

            if (Codigo == 0)
                Codigo = _dbManager.SelectValue<int>(SQL_IDREFRESH);

            _dbManager.Close();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(CodigoEntrada))
                throw new ApplicationException("Preencha o código de entrada");
        }


        #region propriedades

        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public bool? Ativo { get; set; }

        public string CodigoEntrada { get; set; }

        public string CaminhoArquivoImagem { get; set; }


        public string CodigoSaida { get; set; }

        #endregion
    }
}