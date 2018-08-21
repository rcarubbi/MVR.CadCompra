using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MVR.CadCompra.DAL;

namespace MVR.CadCompra.BLL
{
    public class ItemCompraCodigoEntradaComparer : IEqualityComparer<ItemCompra>
    {
        public bool Equals(ItemCompra x, ItemCompra y)
        {
            return x.Produto.CodigoEntrada == y.Produto.CodigoEntrada;
        }

        public int GetHashCode(ItemCompra obj)
        {
            return obj.Produto.CodigoEntrada.GetHashCode();
        }
    }


    public class ItemCompra
    {
        public const string SQL_SELECT = "Select * from TB_ITEM_COMPRA where 1=1";
        public const string SQL_SELECT_POR_COMPRA = "Select * from tb_item_compra where codigoCompra = {0}";
        public const string SQL_OBTER = "Select * from TB_ITEM_COMPRA where codigo={0}";

        public const string SQL_UPDATE =
            "Update tb_item_compra set Preco = {1}, Quantidade = {2}, CodigoCompra = {3}, CodigoProduto = {4} where Codigo = {0}";

        public const string SQL_INSERT =
            "Insert into Tb_item_compra (Preco, Quantidade, CodigoCompra, CodigoProduto) values ({1}, {2}, {3}, {4})";

        public const string SQL_IDREFRESH = "Select max(codigo) from tb_item_compra";

        public static ItemCompraCodigoEntradaComparer PesquisaPorCodigoEntrada = new ItemCompraCodigoEntradaComparer();
        private Compra _compra;
        private readonly DBManager _dbManager;
        private Produto _produto;

        public ItemCompra()
        {
            _dbManager = new DBManager();
        }

        public ItemCompra(int codigo)
            : this()
        {
            if (codigo > 0)
            {
                Codigo = codigo;
                _dbManager.Open();
                var drItemCompra = _dbManager.SelectData(string.Format(SQL_OBTER, Codigo.ToString()));
                ConvertThisItemCompra(drItemCompra);
                _dbManager.Close();
            }
        }

        public int CodigoProduto { get; private set; }

        public int CodigoCompra { get; private set; }

        public decimal Preco { get; set; }


        public int Quantidade { get; set; }

        public int Codigo { get; set; }

        public Produto Produto
        {
            get
            {
                if (_produto == null) _produto = new Produto(CodigoProduto);

                return _produto;
            }
            set => _produto = value;
        }

        public Compra Compra
        {
            get
            {
                if (_compra == null) _compra = new Compra(CodigoCompra);

                return _compra;
            }
            set => _compra = value;
        }

        public static ItemCompra ConvertItemCompra(IDataReader dr)
        {
            var i = new ItemCompra();
            i.Codigo = Convert.ToInt32(dr["Codigo"]);
            i.Quantidade = Convert.ToInt32(dr["Quantidade"]);
            i.Preco = Convert.ToDecimal(dr["Preco"]);
            i.CodigoProduto = Convert.ToInt32(dr["CodigoProduto"]);
            i.CodigoCompra = Convert.ToInt32(dr["CodigoCompra"]);
            return i;
        }

        private void ConvertThisItemCompra(IDataReader dr)
        {
            Codigo = Convert.ToInt32(dr["Codigo"]);
            Preco = Convert.ToDecimal(dr["Preco"]);
            Quantidade = Convert.ToInt32(dr["Quantidade"]);
            CodigoProduto = Convert.ToInt32(dr["CodigoProduto"]);
            CodigoCompra = Convert.ToInt32(dr["CodigoCompra"]);
        }

        public void Salvar()
        {
            _dbManager.Open();

            var sql = new StringBuilder();
            string sqlCommand;
            if (Codigo > 0)
                sqlCommand = SQL_UPDATE;
            else
                sqlCommand = SQL_INSERT;

            sql.AppendFormat(sqlCommand, Codigo, Preco.ToString().Replace(',', '.'), Quantidade, Compra.Codigo,
                Produto.Codigo);
            _dbManager.ExecuteSql(sql.ToString());

            if (Codigo == 0)
                Codigo = _dbManager.SelectValue<int>(SQL_IDREFRESH);

            _dbManager.Close();
        }
    }
}