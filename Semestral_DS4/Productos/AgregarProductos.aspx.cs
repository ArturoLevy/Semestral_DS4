using System;
using Semestral_DS4.DAL;
using Semestral_DS4.Models;

namespace Semestral_DS4.Productos
{
    public partial class AgregarProductos : System.Web.UI.Page
    {
        DataAccessLayer dal = new DataAccessLayer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategorias();
            }
        }

        private void CargarCategorias()
        {
            ddlCategoria.DataSource = dal.GetCategorias(); 
            ddlCategoria.DataTextField = "Nombre";
            ddlCategoria.DataValueField = "ID";
            ddlCategoria.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Producto nuevoProducto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Cantidad = int.Parse(txtCantidad.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                    Marca = txtMarca.Text,
                    Proveedor = txtProveedor.Text,
                    Ubicacion = txtUbicacion.Text,
                    CategoriaID = int.Parse(ddlCategoria.SelectedValue),
                    FechaIngreso = DateTime.Now
                };

                dal.AddProducto(nuevoProducto);
                Response.Redirect("ListarProductos.aspx");
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            // Redirigir a la página de listado de productos
            Response.Redirect("ListarProductos.aspx");
        }
    }
}
