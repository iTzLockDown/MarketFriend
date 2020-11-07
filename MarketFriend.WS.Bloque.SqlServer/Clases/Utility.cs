using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MarketFriend.WS.Bloque.SqlServer.Clases
{
    internal static class Utility
    {
        public static void AddParameter(
            this SqlCommand command,
            string paramaterName,
            SqlDbType dataType,
            int length,
            byte precision,
            byte scale,
            ParameterDirection direction,
            object value)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = paramaterName;
            sqlParameter.SqlDbType = dataType;
            if ((uint)length > 0U)
                sqlParameter.Size = length;
            if (precision > (byte)0)
            {
                sqlParameter.Precision = precision;
                sqlParameter.Scale = scale;
            }
            sqlParameter.Direction = direction;
            sqlParameter.Value = value;
            command.Parameters.Add(sqlParameter);
        }
    }
}
