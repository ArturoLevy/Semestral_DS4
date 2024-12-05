using Semestral_DS4.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Semestral_DS4.DAL
{

    public class DataAccessLayer
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // Obtener todos los productos
        public List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Cantidad = (int)reader["Cantidad"],
                        Precio = (decimal)reader["Precio"],
                        CategoriaID = (int)reader["CategoriaID"],
                        Marca = reader["Marca"].ToString(),
                        Proveedor = reader["Proveedor"].ToString(),
                        FechaIngreso = (DateTime)reader["FechaIngreso"],
                        Ubicacion = reader["Ubicacion"].ToString()
                    });
                }
            }

            return productos;
        }

        // Agregar un producto
        public void AddProducto(Producto producto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Productos (Nombre, Descripcion, Cantidad, Precio, CategoriaID, Marca, Proveedor, FechaIngreso, Ubicacion) " +
                               "VALUES (@Nombre, @Descripcion, @Cantidad, @Precio, @CategoriaID, @Marca, @Proveedor, @FechaIngreso, @Ubicacion)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                command.Parameters.AddWithValue("@Marca", producto.Marca ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@FechaIngreso", producto.FechaIngreso = producto.FechaIngreso == DateTime.MinValue ? DateTime.Now : producto.FechaIngreso);
                command.Parameters.AddWithValue("@Ubicacion", producto.Ubicacion ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Actualizar un producto
        public void UpdateProducto(Producto producto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Nombre=@Nombre, Descripcion=@Descripcion, Cantidad=@Cantidad, Precio=@Precio, " +
                               "CategoriaID=@CategoriaID, Marca=@Marca, Proveedor=@Proveedor, Ubicacion=@Ubicacion " +
                               "WHERE ID=@ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", producto.ID);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                command.Parameters.AddWithValue("@Marca", producto.Marca ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Ubicacion", producto.Ubicacion ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Eliminar un producto
        public void DeleteProducto(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Productos WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Categoria> GetCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Categorias";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString()
                    });
                }
            }

            return categorias;
        }

        public Producto GetProductoById(int id)
        {
            Producto producto = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    producto = new Producto
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Cantidad = (int)reader["Cantidad"],
                        Precio = (decimal)reader["Precio"],
                        Marca = reader["Marca"].ToString(),
                        Proveedor = reader["Proveedor"].ToString(),
                        FechaIngreso = (DateTime)reader["FechaIngreso"],
                        Ubicacion = reader["Ubicacion"].ToString(),
                        CategoriaID = (int)reader["CategoriaID"]
                    };
                }
            }

            return producto;
        }

    }
}