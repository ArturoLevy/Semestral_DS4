using Semestral_DS4.DAL;
using Semestral_DS4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semestral_DS4.Productos
{
    public partial class EditarProductos : System.Web.UI.Page
    {
        DataAccessLayer dal = new DataAccessLayer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["ID"], out int id))
                {
                    CargarCategorias();
                    CargarProducto(id);
                }
                else
                {
                    Response.Redirect("ListarProductos.aspx");
                }
            }
        }

        private void CargarCategorias()
        {
            ddlCategoria.DataSource = dal.GetCategorias();
            ddlCategoria.DataTextField = "Nombre";
            ddlCategoria.DataValueField = "ID";
            ddlCategoria.DataBind();
        }

        private void CargarProducto(int id)
        {
            // Obtener el producto de la base de datos
            Producto producto = dal.GetProductoById(id); // Asegúrate de tener este método en tu DAL

            // Precargar los datos en los controles
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            txtMarca.Text = producto.Marca;
            txtProveedor.Text = producto.Proveedor;
            txtUbicacion.Text = producto.Ubicacion;
            ddlCategoria.SelectedValue = producto.CategoriaID.ToString();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del producto desde la URL
            int id = int.Parse(Request.QueryString["ID"]);

            // Crear un objeto producto con los datos actualizados
            Producto productoActualizado = new Producto
            {
                ID = id,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = decimal.Parse(txtPrecio.Text),
                Marca = txtMarca.Text,
                Proveedor = txtProveedor.Text,
                Ubicacion = txtUbicacion.Text,
                CategoriaID = int.Parse(ddlCategoria.SelectedValue)
            };

            // Actualizar el producto en la base de datos
            dal.UpdateProducto(productoActualizado);

            // Redirigir a la lista de productos
            Response.Redirect("ListarProductos.aspx");
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            // Redirigir a la página de listado de productos
            Response.Redirect("ListarProductos.aspx");
        }
    }
}