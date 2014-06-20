using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MVR.CadCompra.DAL;

namespace MVR.CadCompra.BLL
{
    public class Compra
    {
        private DBManager _dbManager;
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
                IDataReader drCompra = _dbManager.SelectData(string.Format(Compra.SQL_OBTER, Codigo.ToString()));
                ConvertThisCompra(drCompra);
                _dbManager.Close();
            }
        }


        #region Propriedades


        public int Codigo
        {
            get;
            set;
        }

        public string Processo
        {
            get;
            set;
        }

        public DateTime? Data
        {
            get;
            set;
        }

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

                        IDataReader drItensCompra = _dbManager.SelectData(string.Format(ItemCompra.SQL_SELECT_POR_COMPRA, this.Codigo.ToString()));
                        _itens = _dbManager.CarregarLista<ItemCompra>(drItensCompra, ItemCompra.ConvertItemCompra);
                        _dbManager.Close();
                    }
                }

                return _itens;
            }

        }

        #endregion

        public const string SQL_SELECT = "SELECT distinct c.* FROM TB_Produto AS p INNER JOIN (TB_Compra AS c INNER JOIN TB_Item_Compra AS i ON c.Codigo = i.CodigoCompra) ON p.Codigo = i.CodigoProduto where 1=1";
        public const string SQL_OBTER = "Select * from TB_COMPRA where Codigo = {0}";
        public const string SQL_UPDATE = "Update TB_COMPRA set Data = '{1}', Processo = '{2}' where Codigo = {0} ";
        public const string SQL_INSERT = "Insert into TB_COMPRA (Data, Processo) Values ('{1}', '{2}') ";
        public const string SQL_IDREFRESH = "Select max(codigo) from TB_COMPRA";

        public static Compra ConvertCompra(IDataReader dr)
        {
            Compra c = new Compra();
            c.Codigo = Convert.ToInt32(dr["Codigo"]);
            c.Processo = dr["Processo"].ToString();
            c.Data = Convert.ToDateTime(dr["Data"]);
            return c;
        }

        private void ConvertThisCompra(IDataReader dr)
        {
            this.Codigo = Convert.ToInt32(dr["Codigo"]);
            this.Processo = dr["Processo"].ToString();
            this.Data = Convert.ToDateTime(dr["Data"]);
        }

        public void AdicionarItem(ItemCompra i)
        {
            i.Compra = this;
            Itens.Add(i);
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

            sql.AppendFormat(sqlCommand, this.Codigo, this.Data.Value.ToString("yyyy-MM-dd"), this.Processo);
            _dbManager.ExecuteSql(sql.ToString());

            if (Codigo == 0)
                this.Codigo = _dbManager.SelectValue<int>(SQL_IDREFRESH);

            _dbManager.Close();

            foreach (ItemCompra i in this.Itens)
            {
                i.Salvar();
            }


        }

        private void Validar()
        {
            if (this.Codigo == 0 && Compra.Listar(new Compra() { Processo = this.Processo }, null, null).Count > 0)
                throw new ApplicationException("Processo já existente");

            if (string.IsNullOrEmpty(this.Processo))
                throw new ApplicationException("Preencha o Processo");

            if (this.Itens.Count == 0)
                throw new ApplicationException("Adicione ao menos um Item à compra");
        }



        public static List<Compra> Listar(Compra compraInicio, Compra compraFim, Produto produtoFiltro)
        {
            ValidarFiltro(compraInicio, compraFim, produtoFiltro);

            DBManager dbManager = new DBManager();
            dbManager.Open();

            StringBuilder stbSelect = new StringBuilder(SQL_SELECT);

            if (compraInicio != null)
            {
                if (!string.IsNullOrEmpty(compraInicio.Processo))
                {
                    stbSelect.AppendFormat(" and c.Processo = '{0}'", compraInicio.Processo);
                }

                if (compraInicio.Data.HasValue)
                {
                    stbSelect.AppendFormat(" and c.Data >= #{0} 00:00:00#", compraInicio.Data.Value.ToString("yyyy-MM-dd"));
                }
            }
            if (compraFim != null)
            {
                if (compraFim.Data.HasValue)
                {
                    stbSelect.AppendFormat(" and  c.Data <= #{0} 23:59:59#", compraFim.Data.Value.ToString("yyyy-MM-dd"));
                }
            }

            if (produtoFiltro != null)
            {
                if (!string.IsNullOrEmpty(produtoFiltro.CodigoEntrada))
                {
                    stbSelect.AppendFormat(" and p.CodigoEntrada = '{0}'", produtoFiltro.CodigoEntrada);
                }

                if (!string.IsNullOrEmpty(produtoFiltro.CodigoSaida))
                {
                    stbSelect.AppendFormat(" and p.CodigoSaida = '{0}'", produtoFiltro.CodigoSaida);
                }
            }

            IDataReader dr = dbManager.SelectData(stbSelect.ToString());
            List<Compra> compras = dbManager.CarregarLista<Compra>(dr, ConvertCompra);

            dbManager.Close();
            return compras;
        }

        private static void ValidarFiltro(Compra compraInicio, Compra compraFim, Produto produtoFiltro)
        {
            if (compraInicio != null && compraFim != null && compraFim.Data.HasValue && compraInicio.Data.HasValue && compraFim.Data.Value.Date < compraInicio.Data.Value.Date)
                throw new ApplicationException("A data final deve ser superior a data inicial");

            if (produtoFiltro != null && string.IsNullOrEmpty(produtoFiltro.CodigoEntrada) && string.IsNullOrEmpty(produtoFiltro.CodigoSaida))
                throw new ApplicationException("Preencha o código de entrada ou o código de saída");
        }


        public void AdicionarItens(List<ItemCompra> itens)
        {
            foreach (ItemCompra i in itens)
                AdicionarItem(i);
        }
    }
}
