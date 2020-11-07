using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using MarketFriend.WS.Bloque.SqlServer.Interfaces;

namespace MarketFriend.WS.Bloque.SqlServer.Clases
{
    public class SqlHelperWS: ISqlHelper, IDisposable
    {
        private short commadTimeOut = Convert.ToInt16("15");
        private string connectionString = "";
        public SqlConnection connection;
        private SqlCommand command;

        public SqlHelperWS(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
            this.connectionString = connectionString;
        }

        public SqlDataReader ExecuteReader(string storedProcedureName)
        {
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            SqlDataReader sqlDataReader;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                sqlDataReader = this.command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sqlDataReader;
        }

        public SqlDataReader ExecuteReader(
          string storedProcedureName,
          SqlParameterItem sqlParameterItem)
        {
            if (sqlParameterItem == null)
                throw new ArgumentNullException(nameof(sqlParameterItem));
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            this.command.AddParameter(sqlParameterItem.ParameterName, sqlParameterItem.DataType, sqlParameterItem.Length, sqlParameterItem.Precision, sqlParameterItem.Scale, sqlParameterItem.Direction, sqlParameterItem.Value);
            SqlDataReader sqlDataReader;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                sqlDataReader = this.command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sqlDataReader;
        }

        public SqlDataReader ExecuteReader(
          string storedProcedureName,
          List<SqlParameterItem> sqlParameterList)
        {
            if (sqlParameterList == null)
                throw new ArgumentNullException(nameof(sqlParameterList));
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            foreach (SqlParameterItem sqlParameter in sqlParameterList)
                this.command.AddParameter(sqlParameter.ParameterName, sqlParameter.DataType, sqlParameter.Length, sqlParameter.Precision, sqlParameter.Scale, sqlParameter.Direction, sqlParameter.Value);
            SqlDataReader sqlDataReader;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                sqlDataReader = this.command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sqlDataReader;
        }

        public object ExecuteScalar(string storedProcedureName)
        {
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            object obj;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                obj = this.command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public object ExecuteScalar(string storedProcedureName, SqlParameterItem sqlParameterItem)
        {
            if (sqlParameterItem == null)
                throw new ArgumentNullException(nameof(sqlParameterItem));
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            this.command.AddParameter(sqlParameterItem.ParameterName, sqlParameterItem.DataType, sqlParameterItem.Length, sqlParameterItem.Precision, sqlParameterItem.Scale, sqlParameterItem.Direction, sqlParameterItem.Value);
            object obj;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                obj = this.command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public object ExecuteScalar(string storedProcedureName, List<SqlParameterItem> sqlParameterList)
        {
            if (sqlParameterList == null)
                throw new ArgumentNullException(nameof(sqlParameterList));
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            foreach (SqlParameterItem sqlParameter in sqlParameterList)
                this.command.AddParameter(sqlParameter.ParameterName, sqlParameter.DataType, sqlParameter.Length, sqlParameter.Precision, sqlParameter.Scale, sqlParameter.Direction, sqlParameter.Value);
            object obj;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                obj = this.command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public bool ExecuteNonQuery(string storedProcedureName)
        {
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            bool flag;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                this.command.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public bool ExecuteNonQuery(string storedProcedureName, SqlParameterItem sqlParameterItem)
        {
            if (sqlParameterItem == null)
                throw new ArgumentNullException(nameof(sqlParameterItem));
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            this.command.AddParameter(sqlParameterItem.ParameterName, sqlParameterItem.DataType, sqlParameterItem.Length, sqlParameterItem.Precision, sqlParameterItem.Scale, sqlParameterItem.Direction, sqlParameterItem.Value);
            bool flag;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                this.command.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public bool ExecuteNonQuery(string storedProcedureName, List<SqlParameterItem> sqlParameterList)
        {
            if (sqlParameterList == null)
                throw new ArgumentNullException(nameof(sqlParameterList));
            this.command = this.connection.CreateCommand();
            this.command.CommandText = storedProcedureName;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandTimeout = (int)this.commadTimeOut;
            foreach (SqlParameterItem sqlParameter in sqlParameterList)
                this.command.AddParameter(sqlParameter.ParameterName, sqlParameter.DataType, sqlParameter.Length, sqlParameter.Precision, sqlParameter.Scale, sqlParameter.Direction, sqlParameter.Value);
            bool flag;
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                    this.connection.Open();
                this.command.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public object GetParameterOutput(string parameterOutputName)
        {
            object obj = (object)null;
            if (this.command != null && (!string.IsNullOrEmpty(parameterOutputName) && this.command.Parameters.Contains(parameterOutputName) && this.command.Parameters[parameterOutputName].Direction == ParameterDirection.Output))
                obj = this.command.Parameters[parameterOutputName].Value;
            return obj;
        }

        public object GetParameterInputOutput(string parameterOutputName)
        {
            object obj = (object)null;
            if (this.command != null && (!string.IsNullOrEmpty(parameterOutputName) && this.command.Parameters.Contains(parameterOutputName) && this.command.Parameters[parameterOutputName].Direction == ParameterDirection.InputOutput))
                obj = this.command.Parameters[parameterOutputName].Value;
            return obj;
        }

        public void CloseConnection()
        {
            if (this.connection == null)
                return;
            if (this.connection.State == ConnectionState.Open)
                this.connection.Close();
            this.connection.Dispose();
        }

        public void Dispose()
        {
            if (this.connection != null)
            {
                if (this.connection.State == ConnectionState.Open)
                    this.connection.Close();
                this.connection.Dispose();
            }
            GC.SuppressFinalize((object)this);
        }
    }
}
