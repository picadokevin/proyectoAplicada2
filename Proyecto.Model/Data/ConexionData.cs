
using MySql.Data.MySqlClient;
using Npgsql;
using Proyecto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace Proyecto.Model.Data
{
    public class ConexionData
    {

        String connectionString;

        public ConexionData(string connectionString)
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
            NpgsqlConnection con = new NpgsqlConnection("Server= SG-aplicada-177-pgsql-master.servers.mongodirector.com;User Id=sgpostgres;" +
                 "Password=G-AmuVJOw494lHV4;Database=postgres;"); 
            con.Open();

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand("SELECT* FROM suppliers", con);

            NpgsqlDataReader rdr = command.ExecuteReader();
            List<Key> keylist = new List<Key>();
            while (rdr.Read())
            {
                Key key = new Key();


                key.CodKey = rdr["keySupplier"].ToString();
                key.IdSuppliers = Convert.ToInt32(rdr["idSupplier"]);

                keylist.Add(key);
            }
            con.Close();
            return keylist;
        }



        public List<Producto> getAllProducts(String key)
        {

           

         
            List<Producto> productList = new List<Producto>();
            List<Key> suppliers = new List<Key>();
            suppliers = GetKey(key);

            if (GetKey(key).Count >= 1)
            {
                foreach (Key k in suppliers)
                {
                    if (k.IdSuppliers==1)
                    {
                        MySqlConnection conn = new MySqlConnection("Server=163.178.107.130;User Id=laboratorios; " +
                  "Password=UCRSA.118;Database=hc_laptops;");
                        conn.Open();
                        // Define a query returning a single row result set
                        MySqlCommand command = new MySqlCommand("SELECT * FROM listap", conn);

                        MySqlDataReader rdr = command.ExecuteReader();
                        while (rdr.Read())
                        {
                            Producto product = new Producto();

                            product.CodProduct = Convert.ToInt32(rdr["idProduct"]);
                            product.NameProduct = rdr["nameProduct"].ToString();
                            product.PriceProduct = Convert.ToInt32(rdr["priceProduct"]);
                            product.DescriptionProduct = rdr["descProduct"].ToString();
                            product.Image = rdr["imagLaptop"].ToString();
                            product.Category.DetailCategory = rdr["category"].ToString();

                            productList.Add(product);
                        }
                        conn.Close();

                    }
                    else if (k.IdSuppliers == 2)
                    {
                        MySqlConnection conn = new MySqlConnection("Server=163.178.107.130;User Id=laboratorios; " +
                "Password=UCRSA.118;Database=hc_cameras;");
                        conn.Open();
                        // Define a query returning a single row result set
                        MySqlCommand command = new MySqlCommand("SELECT * FROM listap", conn);

                        MySqlDataReader rdr = command.ExecuteReader();
                        while (rdr.Read())
                        {
                            Producto product = new Producto();

                            product.CodProduct = Convert.ToInt32(rdr["idProduct"]);
                            product.NameProduct = rdr["nameProduct"].ToString();
                            product.PriceProduct = Convert.ToInt32(rdr["priceProduct"]);
                            product.DescriptionProduct = rdr["descProduct"].ToString();
                            product.Image = rdr["imagLaptop"].ToString();
                            product.Category.DetailCategory = rdr["category"].ToString();

                            productList.Add(product);
                        }
                        conn.Close();
                    }
                    else
                    {
                        MySqlConnection conn = new MySqlConnection("Server=163.178.107.130;User Id=laboratorios; " +
                "Password=UCRSA.118;Database=hc_smartphones;");
                        conn.Open();
                        // Define a query returning a single row result set
                        MySqlCommand command = new MySqlCommand("SELECT * FROM listap", conn);

                        MySqlDataReader rdr = command.ExecuteReader();
                        while (rdr.Read())
                        {
                            Producto product = new Producto();

                            product.CodProduct = Convert.ToInt32(rdr["idProduct"]);
                            product.NameProduct = rdr["nameProduct"].ToString();
                            product.PriceProduct = Convert.ToInt32(rdr["priceProduct"]);
                            product.DescriptionProduct = rdr["descProduct"].ToString();
                            product.Image = rdr["imagLaptop"].ToString();
                            product.Category.DetailCategory = rdr["category"].ToString();

                            productList.Add(product);
                        }
                        conn.Close();
                    }
                }


                  
               
            }
            return productList;
        }
    }
}