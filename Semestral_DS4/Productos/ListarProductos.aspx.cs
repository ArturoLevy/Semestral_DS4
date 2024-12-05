using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Semestral_DS4.DAL;
using Semestral_DS4.Models;

namespace Semestral_DS4.Productos
{
    public partial class ListarProductos : System.Web.UI.Page
    {
        DataAccessLayer dal = new DataAccessLayer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            gvProductos.DataSource = dal.GetProductos();
            gvProductos.DataBind();
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Redirige al formulario de agregar
            Response.Redirect("AgregarProductos.aspx");
        }

        protected void gvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Validar si el CommandArgument es un número
            if (e.CommandArgument != null && int.TryParse(e.CommandArgument.ToString(), out int rowIndex))

            {
                // Obtener el ID del producto usando el índice de la fila
                int id = Convert.ToInt32(gvProductos.DataKeys[rowIndex].Value);

                if (e.CommandName == "Edit")
                {
                    // Redirigir al formulario de edición
                    Response.Redirect($"EditarProductos.aspx?ID={id}");
                }
                else if (e.CommandName == "CustomDelete")
                {
                    // Llamar al método DAL para eliminar el producto
                    dal.DeleteProducto(id);

                    // Recargar los productos después de la eliminación
                    CargarProductos();
                }
            }
            else
            {
                // Manejar el caso en que CommandArgument no es válido
                // Puedes mostrar un mensaje o registrar el error
                Response.Write("<script>alert('No se pudo procesar la acción. Índice no válido.');</script>");
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            // Redirige a la página de listado de productos
            Response.Redirect("ListarProductos.aspx");
        }
    }
}