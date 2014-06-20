using System;
using System.Collections.Generic;
using System.Text;
using MVR.CadCompra.DAL;
using System.Data;

namespace MVR.CadCompra.BLL
{
    public class Produto
    {
        protected DBManager _dbManager;


        #region propriedades
        public int Codigo
        {
            get;
            set;
        }

        public string Descricao
        {
            get;
            set;
        }

        public bool? Ativo
        {
            get;
            set;
        }

        public string CodigoEntrada
        {
            get;
            set;
        }

        public string CaminhoArquivoImagem
        {
            get;
            set;
        }


        public string CodigoSaida
        {
            get;
            set;
        }

        #endregion


        public static List<Produto> Listar(Produto filtro)
        {


            DBManager dbManager = new DBManager();
            dbManager.Open();

            StringBuilder stbSelect = new StringBuilder(SQL_SELECT);


            if (filtro.Codigo > 0)
            {
                stbSelect.AppendFormat(" and Codigo = {0}", filtro.Codigo);
            }

            if (!string.IsNullOrEmpty(filtro.Descricao))
            {
                stbSelect.AppendFormat(" and Descricao like '%{0}%'", filtro.Descricao);
            }

            if (filtro.Ativo.HasValue)
            {
                stbSelect.AppendFormat(" and Ativo = {0}", filtro.Ativo.Value ? "True" : "False");
            }

            if (!string.IsNullOrEmpty(filtro.CodigoEntrada))
            {
                stbSelect.AppendFormat(" and CodigoEntrada = '{0}'", filtro.CodigoEntrada);
            }

            if (!string.IsNullOrEmpty(filtro.CodigoSaida))
            {
                stbSelect.AppendFormat(" and CodigoSaida = '{0}'", filtro.CodigoSaida);
            }


            IDataReader dr = dbManager.SelectData(stbSelect.ToString());
            List<Produto> produtos = dbManager.CarregarLista<Produto>(dr, ConvertProduto);

            dbManager.Close();
            return produtos;

        }

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
                IDataReader drProduto = _dbManager.SelectData(string.Format(Produto.SQL_OBTER, Codigo.ToString()));
                ConvertThisProduto(drProduto);
                _dbManager.Close();
            }
        }

        private void ConvertThisProduto(IDataReader dr)
        {
            dr.Read();
            try
            {
                this.Codigo = Convert.ToInt32(dr["Codigo"]);
                this.Descricao = dr["Descricao"].ToString();
                this.Ativo = Convert.ToBoolean(dr["Ativo"]);
                this.CodigoEntrada = dr["CodigoEntrada"].ToString();
                this.CodigoSaida = dr["CodigoSaida"].ToString();
                this.CaminhoArquivoImagem = dr["CaminhoArquivoImagem"].ToString();
            }
            catch (Exception ex)
            {
                throw new NotFoundException(ex);
            }
        }

        public static Produto ConvertProduto(IDataReader dr)
        {
            Produto p = new Produto();
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
            this.Validar();
            _dbManager.Open();

            StringBuilder sql = new StringBuilder();
            string sqlCommand;
            if (Codigo > 0)
                sqlCommand = SQL_UPDATE;
            else
                sqlCommand = SQL_INSERT;

            sql.AppendFormat(sqlCommand, this.Codigo.ToString(), this.Descricao, this.Ativo.ToString(), this.CodigoEntrada, this.CodigoSaida, this.CaminhoArquivoImagem);
            _dbManager.ExecuteSql(sql.ToString());

            if (Codigo == 0)
                this.Codigo = _dbManager.SelectValue<int>(SQL_IDREFRESH);

            _dbManager.Close();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(this.CodigoEntrada))
                throw new ApplicationException("Preencha o código de entrada");
        }



        public const string SQL_OBTER = "Select * from TB_PRODUTO where Codigo = {0}";
        public const string SQL_INSERT = "insert into tb_produto (Descricao, Ativo, CodigoEntrada, CodigoSaida, CaminhoArquivoImagem) values ('{1}',{2}, '{3}', '{4}', '{5}')";
        public const string SQL_UPDATE = "Update tb_produto set Descricao = '{1}', Ativo = {2}, CodigoEntrada = '{3}', CodigoSaida = '{4}', CaminhoArquivoImagem = '{5}' where codigo = {0}";
        public const string SQL_SELECT = "Select * from tb_produto where 1=1";
        public const string SQL_IDREFRESH = "Select max(codigo) from tb_produto";

    }
}
