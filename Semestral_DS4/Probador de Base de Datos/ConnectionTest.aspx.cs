using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semestral_DS4.Probador_de_Base_de_Datos
{
    public partial class ConnectionTest : System.Web.UI.Page
    {
        protected void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    lblStatus.Text = "Conexión exitosa a la base de datos.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error al conectar: " + ex.Message;
            }
        }
    }
}