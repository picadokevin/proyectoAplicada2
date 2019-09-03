
using MySql.Data.MySqlClient;
using Npgsql;
using Proyecto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace Proyecto.Model.Data
{
    public class Conexion
    {

        String connectionString;

        public Conexion(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public NpgsqlConnection connection()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            var connectionChain = "server=;Port=;UserId=;Password=;Database=";
            if (!string.IsNullOrWhiteSpace(connectionChain))
            {
                try
                {
                    connection = new NpgsqlConnection(connectionChain);
                    connection.Open();

                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
            return connection;
        }


        public List<Key> GetKey(String Key)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " +
                 "Password=pwd;Database=postgres;");
            conn.Open();

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM cities", conn);

            NpgsqlDataReader rdr = command.ExecuteReader();
            List<Key> keylist = new List<Key>();
            while (rdr.Read())
            {
                Key key = new Key();


                key.CodKey = rdr["Name"].ToString();
                key.Status1 = Convert.ToInt32(rdr["StudentID"]);

                keylist.Add(key);
            }
            conn.Close();
            return keylist;
        }



        public List<Producto> getAllProducts(String key)
        {

            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;User Id=postgres; " +
                     "Password=pwd;Database=postgres;");
            conn.Open();

            // Define a query returning a single row result set
            MySqlCommand command = new MySqlCommand("SELECT ALL FROM productos", conn);

            MySqlDataReader rdr = command.ExecuteReader();
            List<Producto> productList = new List<Producto>();
            if (GetKey(key).Count>=1)
                while (rdr.Read())
                {
                    Producto product = new Producto();

                    product.CodProduct = Convert.ToInt32(rdr["StudentID"]);
                    product.NameProduct = rdr["Name"].ToString();
                    product.PriceProduct = Convert.ToInt32(rdr["StudentID"]);
                    product.DescriptionProduct = rdr["Name"].ToString();
                    product.Image = rdr["Name"].ToString();
                    product.Category.CodCategory = Convert.ToInt32(rdr["StudentID"]);
                    
                   productList.Add(product);
                }
            conn.Close();
            return productList;
        }
    }
}