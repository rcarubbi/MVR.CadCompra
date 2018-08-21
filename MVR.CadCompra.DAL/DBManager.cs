using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace MVR.CadCompra.DAL
{
    public delegate T LoadListHandler<T>(IDataReader dr);

    public class DBManager : IDisposable
    {
        private OleDbCommand _command;

        private OleDbConnection _connection;

        public void Dispose()
        {
            Close();
            _command.Dispose();
            _connection.Dispose();
            _command = null;
            _connection = null;
        }

        public List<T> CarregarLista<T>(IDataReader dr, LoadListHandler<T> convertMethod)
        {
            var listaRetorno = new List<T>();
            while (dr.Read()) listaRetorno.Add(convertMethod(dr));
            return listaRetorno;
        }

        public void Open()
        {
            try
            {
                _connection = new OleDbConnection();
                _connection.ConnectionString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
                _connection.Open();
            }
            catch (OleDbException ex)
            {
                //todo: Tratar exceçao
            }
            catch (Exception ex)
            {
                //todo: Tratar exceçao
            }
        }

        public void ExecuteSql(string sql)
        {
            try
            {
                _command = new OleDbCommand();
                _command.Connection = _connection;
                _command.CommandText = sql;
                _command.CommandType = CommandType.Text;
                _command.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                //todo: Tratar exceçao
                throw ex;
            }
            finally
            {
                _command.Dispose();
                _command = null;
            }
        }

        public U SelectValue<U>(string sql)
        {
            try
            {
                _command = new OleDbCommand();
                _command.Connection = _connection;
                _command.CommandText = sql;
                _command.CommandType = CommandType.Text;
                return (U) _command.ExecuteScalar();
            }
            catch (OleDbException ex)
            {
                //todo: Tratar exceçao
                throw ex;
            }
            finally
            {
                _command.Dispose();
                _command = null;
            }
        }

        public IDataReader SelectData(string sql)
        {
            try
            {
                _command = new OleDbCommand();
                _command.Connection = _connection;
                _command.CommandText = sql;
                _command.CommandType = CommandType.Text;
                return _command.ExecuteReader();
            }
            catch (OleDbException ex)
            {
                //todo: Tratar exceçao
                throw ex;
            }
            finally
            {
                _command.Dispose();
                _command = null;
            }
        }


        public void Close()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            catch (OleDbException ex)
            {
                //todo: Tratar exceçao
            }
            catch (Exception ex)
            {
                //todo: Tratar exceçao
            }
        }
    }
}