using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MarketFriend.WS.Bloque.SqlServer.Funciones
{
    public static class UtilBD
    {
        /// <summary>
        /// Cadena de conexión a base de datos de sql server (SOFCMACHYO)
        /// </summary>
        //public static string ConexionSql
        //{
        //    get
        //    {
        //        string connectionString = ProtectedConfig.ProtectedItems["cnSeguridadBD"].Value;
        //        if (connectionString == null || connectionString == string.Empty)
        //        {
        //            try
        //            {
        //                connectionString = ConfigurationManager.ConnectionStrings["cnSeguridadBD"].ConnectionString;
        //            }
        //            catch (Exception ex)
        //            {
        //            }
        //        }
        //        return connectionString;
        //    }
        //}

        /// <summary>
        /// Cadena de conexión dinamica a base de datos de sql server.
        /// </summary>
        /// <param name="servidor">Servidor remoto al que se va a conectar</param>
        /// <param name="baseDatos">Base de datos del Servidor remoto a la que se quiere acceder</param>
        /// <param name="usuario">Usuario de Windows</param>
        /// <param name="contrasenia">Contraseña</param>
        /// <returns></returns>
        //public static string ConexionDinamicaSql(
        //  string servidor,
        //  string baseDatos,
        //  string usuario,
        //  string contrasenia)
        //{
        //    string empty = string.Empty;
        //    string str;
        //    if (Globales.Dominio == "CMACHYO")
        //        str = string.Format(ProtectedConfig.ProtectedItems["cnSeguridadBDDinamicaConDominio"].Value, (object)servidor, (object)baseDatos);
        //    else
        //        str = string.Format(ProtectedConfig.ProtectedItems["cnSeguridadBDDinamicaSinDominio"].Value, (object)servidor, (object)baseDatos, (object)usuario, (object)contrasenia);
        //    return str;
        //}

        /// <summary>
        /// Cadena de conexión a base de datos de sql server (CMACHYOSPL)
        /// </summary>
        //public static string ConexionSqlSplaft
        //{
        //    get
        //    {
        //        return ProtectedConfig.ProtectedItems["cnSeguridadBDSplaft"].Value;
        //    }
        //}

        /// <summary>
        /// Cadena de conexión a base de datos de sql server (DEFCMACHYO)
        /// </summary>
        //public static string ConexionSqlDefensoria
        //{
        //    get
        //    {
        //        return ProtectedConfig.ProtectedItems["cnSeguridadBDSDC"].Value;
        //    }
        //}

        /// <summary>
        /// Cadena de conexión a base de datos de sql server (HYO13012\HYO13012\DEVJUDICIALES)
        /// </summary>
        //public static string ConexionSqlJudiciales
        //{
        //    get
        //    {
        //        return ProtectedConfig.ProtectedItems["cnSeguridadBDJudiciales"].Value;
        //    }
        //}

        /// <summary>
        /// Obtiene el valor booleano del campo especificado (si el valor es IsDBNull devuelve false)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor booleano del campo</returns>
        public static bool GetBooleanOrFalse(this IDataReader reader, int ordinal)
        {
            return !reader.IsDBNull(ordinal) && reader.GetBoolean(ordinal);
        }

        /// <summary>
        /// Obtiene el valor booleano del campo especificado (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor booleano del campo</returns>
        public static bool? GetBooleanOrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new bool?() : new bool?(reader.GetBoolean(ordinal));
        }

        /// <summary>
        /// Obtiene el valor en tipo byte del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor byte del campo</returns>
        public static byte? GetByteOrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new byte?() : new byte?(reader.GetByte(ordinal));
        }

        /// <summary>
        /// Obtiene el valor en tipo byte del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor byte del campo</returns>
        public static byte GetByteOrZero(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? (byte)0 : reader.GetByte(ordinal);
        }

        /// <summary>
        /// Obtiene el valor de fecha del campo especificado (si el valor es IsDBNull devuelve el 01/01/1900)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor de fecha del campo</returns>
        public static DateTime GetDateTimeOr1900(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new DateTime(1900, 1, 1) : reader.GetDateTime(ordinal);
        }

        /// <summary>
        /// Obtiene el valor de fecha del campo especificado (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor de fecha del campo</returns>
        public static DateTime? GetDateTimeOrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new DateTime?() : new DateTime?(reader.GetDateTime(ordinal));
        }

        /// <summary>
        /// Obtiene el valor decimal del campo especificado (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor decimal del campo</returns>
        public static Decimal? GetDecimalOrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new Decimal?() : new Decimal?(reader.GetDecimal(ordinal));
        }

        /// <summary>
        /// Obtiene el valor decimal del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor decimal del campo</returns>
        public static Decimal GetDecimalOrZero(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? Decimal.Zero : reader.GetDecimal(ordinal);
        }

        /// <summary>
        /// Obtiene el valor entero (short) del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor entero del campo</returns>
        public static short? GetInt16OrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new short?() : new short?(reader.GetInt16(ordinal));
        }

        /// <summary>
        /// Obtiene el valor entero (short) del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor entero del campo</returns>
        public static short GetInt16OrZero(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? (short)0 : reader.GetInt16(ordinal);
        }

        /// <summary>
        /// Obtiene el valor entero (int) del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor entero del campo</returns>
        public static int? GetInt32OrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new int?() : new int?(reader.GetInt32(ordinal));
        }

        /// <summary>
        /// Obtiene el valor entero (int) del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor entero del campo</returns>
        public static int GetInt32OrZero(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? 0 : reader.GetInt32(ordinal);
        }

        /// <summary>
        /// Obtiene el valor entero (long) del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor entero del campo</returns>
        public static long? GetInt64OrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? new long?() : new long?(reader.GetInt64(ordinal));
        }

        /// <summary>
        /// Obtiene el valor entero (long) del campo especificado (si el valor es IsDBNull devuelve cero)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor entero del campo</returns>
        public static long GetInt64OrZero(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? 0L : reader.GetInt64(ordinal);
        }

        /// <summary>
        /// Obtiene el valor de cadena del campo especificado  (si el valor es IsDBNull devuelve vacío)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor de cadena del campo</returns>
        public static string GetStringOrEmpty(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? "" : reader.GetString(ordinal);
        }

        /// <summary>
        /// Obtiene el valor de cadena del campo especificado (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="ordinal">Indice del campo especificado</param>
        /// <returns>Valor de cadena del campo</returns>
        public static string GetStringOrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? (string)null : reader.GetString(ordinal);
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a cadena (si el valor es IsDBNull devuelve vacío)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor de cadena del objeto</returns>
        public static string GetOutputString(object objeto)
        {
            return objeto.ToString();
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a cadena (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor de cadena del objeto</returns>
        public static string GetOutputStringOrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? (string)null : objeto.ToString();
        }

        /// <summary>Convierte el valor del objeto especificado a fecha</summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor de fecha del objeto</returns>
        public static DateTime GetOutputDateTime(object objeto)
        {
            return DateTime.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a fecha (si el valor es IsDBNull devuelve 01/01/1900)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor de fecha del objeto</returns>
        public static DateTime GetOutputDateTimeOr1900(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new DateTime(1900, 1, 1) : DateTime.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a fecha (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor de fecha del objeto</returns>
        public static DateTime? GetOutputDateTimeOrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new DateTime?() : new DateTime?(DateTime.Parse(objeto.ToString()));
        }

        /// <summary>Convierte el valor del objeto especificado a booleano</summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor booleano del objeto</returns>
        public static bool GetOutputBoolean(object objeto)
        {
            return bool.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a booleano (si el valor IsDBNull devuelve false)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor booleano del objeto</returns>
        public static bool GetOutputBooleanOrFalse(object objeto)
        {
            return !Convert.IsDBNull(objeto) && bool.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a booleano (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor booleano del objeto</returns>
        public static bool? GetOutputBooleanOrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new bool?() : new bool?(bool.Parse(objeto.ToString()));
        }

        /// <summary>Convierte el valor del objeto especificado a decimal</summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor decimal del objeto</returns>
        public static Decimal GetOutputDecimal(object objeto)
        {
            return Decimal.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a decimal (si el valor es IsDBNull devuelve 0)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor decimal del objeto</returns>
        public static Decimal GetOutputDecimalOrZero(object objeto)
        {
            return Convert.IsDBNull(objeto) ? Decimal.Zero : Decimal.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a decimal (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor decimal del objeto</returns>
        public static Decimal? GetOutputDecimalOrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new Decimal?() : new Decimal?(Decimal.Parse(objeto.ToString()));
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a double (si el valor es IsDBNull devuelve 0)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor double del objeto</returns>
        public static double GetOutputDoubleOrZero(object objeto)
        {
            return Convert.IsDBNull(objeto) ? 0.0 : double.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a double (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor double del objeto</returns>
        public static double? GetOutputDoubleOrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new double?() : new double?(double.Parse(objeto.ToString()));
        }

        /// <summary>Convierte el valor del objeto especificado a byte</summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor byte del objeto</returns>
        public static byte GetOutputByte(object objeto)
        {
            return byte.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a byte (si el valor es IsDBNull devuelve 0)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor byte del objeto</returns>
        public static byte GetOutputByteOrZero(object objeto)
        {
            return Convert.IsDBNull(objeto) ? (byte)0 : byte.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a byte (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor byte del objeto</returns>
        public static byte? GetOutputByteOrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new byte?() : new byte?(byte.Parse(objeto.ToString()));
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (short)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (short) del objeto</returns>
        public static short GetOutputInt16(object objeto)
        {
            return short.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (short) (si el valor es IsDBNull devuelve 0)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (short) del objeto</returns>
        public static short GetOutputInt16OrZero(object objeto)
        {
            return Convert.IsDBNull(objeto) ? (short)0 : short.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (short) (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (short) del objeto</returns>
        public static short? GetOutputInt16OrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new short?() : new short?(short.Parse(objeto.ToString()));
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (int)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (int) del objeto</returns>
        public static int GetOutputInt32(object objeto)
        {
            return int.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (int) (si el valor es IsDBNull devuelve 0)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (int) del objeto</returns>
        public static int GetOutputInt32OrZero(object objeto)
        {
            return Convert.IsDBNull(objeto) ? 0 : int.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (int) (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (int) del objeto</returns>
        public static int? GetOutputInt32OrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new int?() : new int?(int.Parse(objeto.ToString()));
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (long)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (long) del objeto</returns>
        public static long GetOutputInt64(object objeto)
        {
            return long.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (long) (si el valor es IsDBNull devuelve 0)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (long) del objeto</returns>
        public static long GetOutputInt64OrZero(object objeto)
        {
            return Convert.IsDBNull(objeto) ? 0L : long.Parse(objeto.ToString());
        }

        /// <summary>
        /// Convierte el valor del objeto especificado a entero (long) (si el valor es IsDBNull devuelve null)
        /// </summary>
        /// <param name="objeto">Objeto a convertir</param>
        /// <returns>Valor entero (long) del objeto</returns>
        public static long? GetOutputInt64OrNull(object objeto)
        {
            return Convert.IsDBNull(objeto) ? new long?() : new long?(long.Parse(objeto.ToString()));
        }

        /// <summary>
        /// Recorre las filas de un datareader asociado a un objeto
        /// </summary>
        /// <typeparam name="T">Tipo de objeto asociado</typeparam>
        /// <param name="reader">Objeto que implementa la interfaz IDataReader</param>
        /// <param name="projection">Método que devuelve una instancia de "T" recibiendo como parametro un "reader"</param>
        /// <returns>Lista con la data recorrida del "reader"</returns>
        public static IEnumerable<T> Select<T>(
          this IDataReader reader,
          Func<IDataReader, T> projection)
        {
            while (reader.Read())
                yield return projection(reader);
        }

        /// <summary>
        ///  Devuelve si reader tiene columna con nombre ingresado
        /// </summary>
        /// <param name="reader">Objeto para lectura de datos</param>
        /// <param name="nombreColumna">Nombre de la columna buscada</param>
        /// <returns>Devuelve indicador si columna existe</returns>
        public static bool TieneColumna(this IDataReader reader, string nombreColumna)
        {
            for (int i = 0; i < reader.FieldCount; ++i)
            {
                if (reader.GetName(i).Equals(nombreColumna, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }

}
