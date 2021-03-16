using System;
using System.Data;
using System.Data.Common;

namespace CapaDatos
{
    public class ConexionDeDatos
    {

        private static readonly DbProviderFactory providerFactory;
        private readonly IDbConnection connection;


        static ConexionDeDatos()
        {
            providerFactory = DbProviderFactories.GetFactory("System.Data.OracleClient");
        }

        public ConexionDeDatos()
        {
        
            //PRUEBAS
            string connectionString = "data source=CERTDALI;user id=INTBAW;password=Baw2020TLA";
            connection = providerFactory.CreateConnection();
            connection.ConnectionString = connectionString;

        }

        public ConexionDeDatos(string valor, string valor2)
        {

        }



        public DataTable Query(string sqlString, string BD)
        {
            try
            {
                switch (BD)
                {
                   
                    case "BAW":
                        connection.Open();
                        DataTable devuelve = EjecutarConsulta(connection, sqlString);
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                        return devuelve;

                }
                return null;
            }
            catch (Exception ex)
            {
                DataTable dterror = new DataTable();


                connection.Close();

                return dterror;
            }
        }

        private DataTable EjecutarConsulta(IDbConnection conn, string sqlString)
        {  
                        
            DataTable dtResult = new DataTable();
            
            try
            {
        
            DbDataAdapter adapter = providerFactory.CreateDataAdapter();
            DbCommand command = providerFactory.CreateCommand();
            command.CommandText = sqlString;
            command.Connection = (DbConnection)conn;
            adapter.SelectCommand = command;
          
            adapter.Fill(dtResult);
            conn.Close();
               

            }
            catch (Exception ex )
            {

               

            }

            return dtResult;
        }

        public bool Execute(string sqlString)
        {
            try
            {

                connection.Close();
                connection.Open();
                DbCommand command = providerFactory.CreateCommand();
                command.CommandText = sqlString;
                command.Connection = (DbConnection)connection;


                int resultado = command.ExecuteNonQuery();
                connection.Close();

                if (resultado > 0)
                {
                    return true;
                }
            }

            finally
            {
                connection.Close();
            }
            return false;
        }



        public bool Execute(string sqlString, string BD)
        {
            int Resultado = -1;
            try
            {
                switch (BD)
                {
                    case "BAW":

                        Resultado = EjecutarCommando(connection, sqlString);
                        break;


                }

                if (Resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception EX)
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }


                return false;
            }
        }
        /// <summary>
        /// cambio
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        private int EjecutarCommando(IDbConnection connection, string sqlString)
        {
            try
            {
                connection.Close();
                connection.Open();
                DbCommand command = providerFactory.CreateCommand();
                command.CommandText = sqlString;
                command.Connection = (DbConnection)connection;

                return command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    
        public bool Insert(string sqlString)
        {
            connection.Close();
            connection.Open();
            DbCommand command = providerFactory.CreateCommand();
            command.CommandText = sqlString;
            command.Connection = (DbConnection)connection;
            connection.Close();
            return command.ExecuteNonQuery() > 0;
        }

      
  

    }
}

