<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="Semestral_DS4.Productos.ListarProductos" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Lista de Productos</title>
    <!-- vincluacion con Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <!-- Indice del lado izquierdo -->
                <nav class="col-md-2 d-none d-md-block bg-light sidebar">
                    <div class="position-sticky">
                        <h5 class="mt-3 mb-3 text-center">Menú</h5>
                        <ul class="nav flex-column">
                            <li class="nav-item">
                                <a class="nav-link active" href='<%= ResolveUrl("~/Inicio.aspx") %>'>Inicio</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href='<%= ResolveUrl("~/Productos/ListarProductos.aspx") %>'>Inventario</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href='<%= ResolveUrl("~/Productos/AgregarProductos.aspx") %>'>Agregar Producto</a>
                            </li>
                        </ul>
                    </div>
                </nav>

                <!-- titulo -->
                <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">
                    <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                        <h1 class="h2">Lista de Productos</h1>
                        
                    </div>

                    <!-- Tabla de Productos -->
                    <div class="table-responsive">
                        <asp:GridView ID="gvProductos" runat="server" CssClass="table table-striped table-hover" AutoGenerateColumns="False" DataKeyNames="ID" OnRowCommand="gvProductos_RowCommand">
                            <Columns>
                         
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                                <asp:BoundField DataField="Precio" HeaderText="Precio" DataFormatString="{0:C}" />
                                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" />
                                <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha de Ingreso" DataFormatString="{0:dd/MM/yyyy}" />
                                <asp:BoundField DataField="Ubicacion" HeaderText="Ubicación" />

                     
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <div class="d-flex justify-content-center mt-2">
                                            <asp:LinkButton ID="btnEditar" runat="server" CommandName="Edit" CommandArgument="<%# Container.DataItemIndex %>" Text="Editar"
                                                CssClass="btn btn-sm btn-warning me-2">
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="btnEliminar" runat="server" CommandName="CustomDelete" CommandArgument="<%# Container.DataItemIndex %>" Text="Eliminar"
                                                CssClass="btn btn-sm btn-danger" OnClientClick="return confirm('¿Estás seguro de que deseas eliminar este producto?');">
                                            </asp:LinkButton>
                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </main>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
