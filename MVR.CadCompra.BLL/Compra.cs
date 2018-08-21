using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MVR.CadCompra.DAL;

namespace MVR.CadCompra.BLL
{
    public class Compra
    {
        public const string SQL_SELECT =
            "SELECT distinct c.* FROM TB_Produto AS p INNER JOIN (TB_Compra AS c INNER JOIN TB_Item_Compra AS i ON c.Codigo = i.CodigoCompra) ON p.Codigo = i.CodigoProduto where 1=1";

        public const string SQL_OBTER = "Select * from TB_COMPRA where Codigo = {0}";
        public const string SQL_UPDATE = "Update TB_COMPRA set Data = '{1}', Processo = '{2}' where Codigo = {0} ";
        public const string SQL_INSERT = "Insert into TB_COMPRA (Data, Processo) Values ('{1}', '{2}') ";
        public const string SQL_IDREFRESH = "Select max(codigo) from TB_COMPRA";
        private readonly DBManager _dbManager;
        protected List<ItemCompra> _itens;

        public Compra()
        {
            _dbManager = new DBManager();
        }

        public Compra(int codigo)
            : this()
        {
            if (codigo > 0)
            {
                Codigo = codigo;
                _dbManager.Open();
                var drCompra = _dbManager.SelectData(string.Format(SQL_OBTER, Codigo.ToString()));
                ConvertThisCompra(drCompra);
                _dbManager.Close();
            }
        }

        public static Compra ConvertCompra(IDataReader dr)
        {
            var c = new Compra();
            c.Codigo = Convert.ToInt32(dr["Codigo"]);
            c.Processo = dr["Processo"].ToString();
            c.Data = Convert.ToDateTime(dr["Data"]);
            return c;
        }

        private void ConvertThisCompra(IDataReader dr)
        {
            Codigo = Convert.ToInt32(dr["Codigo"]);
            Processo = dr["Processo"].ToString();
            Data = Convert.ToDateTime(dr["Data"]);
        }

        public void AdicionarItem(ItemCompra i)
        {
            i.Compra = this;
            Itens.Add(i);
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

            sql.AppendFormat(sqlCommand, Codigo, Data.Value.ToString("yyyy-MM-dd"), Processo);
            _dbManager.ExecuteSql(sql.ToString());

            if (Codigo == 0)
                Codigo = _dbManager.SelectValue<int>(SQL_IDREFRESH);

            _dbManager.Close();

            foreach (var i in Itens) i.Salvar();
        }

        private void Validar()
        {
            if (Codigo == 0 && Listar(new Compra {Processo = Processo}, null, null).Count > 0)
                throw new ApplicationException("Processo já existente");

            if (string.IsNullOrEmpty(Processo))
                throw new ApplicationException("Preencha o Processo");

            if (Itens.Count == 0)
                throw new ApplicationException("Adicione ao menos um Item à compra");
        }


        public static List<Compra> Listar(Compra compraInicio, Compra compraFim, Produto produtoFiltro)
        {
            ValidarFiltro(compraInicio, compraFim, produtoFiltro);

            var dbManager = new DBManager();
            dbManager.Open();

            var stbSelect = new StringBuilder(SQL_SELECT);

            if (compraInicio != null)
            {
                if (!string.IsNullOrEmpty(compraInicio.Processo))
                    stbSelect.AppendFormat(" and c.Processo = '{0}'", compraInicio.Processo);

                if (compraInicio.Data.HasValue)
                    stbSelect.AppendFormat(" and c.Data >= #{0} 00:00:00#",
                        compraInicio.Data.Value.ToString("yyyy-MM-dd"));
            }

            if (compraFim != null)
                if (compraFim.Data.HasValue)
                    stbSelect.AppendFormat(" and  c.Data <= #{0} 23:59:59#",
                        compraFim.Data.Value.ToString("yyyy-MM-dd"));

            if (produtoFiltro != null)
            {
                if (!string.IsNullOrEmpty(produtoFiltro.CodigoEntrada))
                    stbSelect.AppendFormat(" and p.CodigoEntrada = '{0}'", produtoFiltro.CodigoEntrada);

                if (!string.IsNullOrEmpty(produtoFiltro.CodigoSaida))
                    stbSelect.AppendFormat(" and p.CodigoSaida = '{0}'", produtoFiltro.CodigoSaida);
            }

            var dr = dbManager.SelectData(stbSelect.ToString());
            var compras = dbManager.CarregarLista(dr, ConvertCompra);

            dbManager.Close();
            return compras;
        }

        private static void ValidarFiltro(Compra compraInicio, Compra compraFim, Produto produtoFiltro)
        {
            if (compraInicio != null && compraFim != null && compraFim.Data.HasValue && compraInicio.Data.HasValue &&
                compraFim.Data.Value.Date < compraInicio.Data.Value.Date)
                throw new ApplicationException("A data final deve ser superior a data inicial");

            if (produtoFiltro != null && string.IsNullOrEmpty(produtoFiltro.CodigoEntrada) &&
                string.IsNullOrEmpty(produtoFiltro.CodigoSaida))
                throw new ApplicationException("Preencha o código de entrada ou o código de saída");
        }


        public void AdicionarItens(List<ItemCompra> itens)
        {
            foreach (var i in itens)
                AdicionarItem(i);
        }


        #region Propriedades

        public int Codigo { get; set; }

        public string Processo { get; set; }

        public DateTime? Data { get; set; }

        public List<ItemCompra> Itens
        {
            get
            {
                if (_itens == null)
                {
                    _itens = new List<ItemCompra>();
                    if (Codigo > 0)
                    {
                        _dbManager.Open();

                        var drItensCompra =
                            _dbManager.SelectData(string.Format(ItemCompra.SQL_SELECT_POR_COMPRA, Codigo.ToString()));
                        _itens = _dbManager.CarregarLista(drItensCompra, ItemCompra.ConvertItemCompra);
                        _dbManager.Close();
                    }
                }

                return _itens;
            }
        }

        #endregion
    }
}