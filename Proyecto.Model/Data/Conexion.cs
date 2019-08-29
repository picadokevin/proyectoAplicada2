using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Model.Data
{
   public class Conexion
    {
        public NpgsqlConnection connection()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            var connectionChain = "server=;Port=;UserId=;Password=;Database=";
            if(!string.IsNullOrWhiteSpace(connectionChain))
            {
                try
                {
                    connection = new NpgsqlConnection(connectionChain);
                    connection.Open();

                }
                catch(Exception)
                {
                    connection.Close();
                }
            }
            return connection;
        }
        
    }
}
