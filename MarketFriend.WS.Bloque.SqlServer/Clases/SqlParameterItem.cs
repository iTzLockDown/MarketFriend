using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MarketFriend.WS.Bloque.SqlServer
{
    public class SqlParameterItem
    {
        public string ParameterName { get; set; }

        public SqlDbType DataType { get; set; }

        public int Length { get; set; }

        public byte Precision { get; set; }

        public byte Scale { get; set; }

        public ParameterDirection Direction { get; set; }

        public object Value { get; set; }

        public SqlParameterItem(
            string parameterName,
            SqlDbType dataType,
            object value,
            ParameterDirection direction = ParameterDirection.Input)
        {
            this.ParameterName = parameterName;
            this.DataType = dataType;
            this.Direction = direction;
            this.Value = value;
        }

        public SqlParameterItem(
            string parameterName,
            SqlDbType dataType,
            int length,
            object value,
            ParameterDirection direction = ParameterDirection.Input)
        {
            this.ParameterName = parameterName;
            this.DataType = dataType;
            this.Length = length;
            this.Direction = direction;
            this.Value = value;
        }

        public SqlParameterItem(
            string parameterName,
            SqlDbType dataType,
            byte precision,
            byte scale,
            object value,
            ParameterDirection direction = ParameterDirection.Input)
        {
            this.ParameterName = parameterName;
            this.DataType = dataType;
            this.Precision = precision;
            this.Scale = scale;
            this.Direction = direction;
            this.Value = value;
        }
    }
}
