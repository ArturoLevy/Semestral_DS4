<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarProductos.aspx.cs" Inherits="Semestral_DS4.Productos.EditarProductos" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Editar Producto</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <!-- Índice de Navegación -->
                <nav class="col-md-2 d-none d-md-block bg-light sidebar">
                    <div class="position-sticky">
                        <h5 class="mt-3 mb-3 text-center">Menú</h5>
                        <ul class="nav flex-column">
                            <li class="nav-item">
                                <a class="nav-link" href='<%= ResolveUrl("~/Inicio.aspx") %>'>Inicio</a>
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

                <!-- Contenido Principal -->
                <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">
                    <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                        <h1 class="h2">Editar Producto</h1>
                    </div>

                    <!-- Formulario de Edición -->
                    <div class="card">
                        <div class="card-header bg-primary text-white">
                            <h5 class="mb-0">Formulario de Edición</h5>
                        </div>
                        <div class="card-body">
                            <div class="mb-3">
                                <label for="txtNombre" class="form-label">Nombre</label>
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="txtDescripcion" class="form-label">Descripción</label>
                                <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="txtCantidad" class="form-label">Cantidad</label>
                                <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="txtPrecio" class="form-label">Precio</label>
                                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="txtMarca" class="form-label">Marca</label>
                                <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="txtProveedor" class="form-label">Proveedor</label>
                                <asp:TextBox ID="txtProveedor" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="txtUbicacion" class="form-label">Ubicación</label>
                                <asp:TextBox ID="txtUbicacion" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="ddlCategoria" class="form-label">Categoría</label>
                                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-select"></asp:DropDownList>
                            </div>
                            <div class="d-flex justify-content-end">
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar Cambios" CssClass="btn btn-success me-2" OnClick="btnGuardar_Click" />
                                <asp:Button ID="btnAtras" runat="server" Text="Atrás" CssClass="btn btn-secondary" CausesValidation="False" OnClick="btnAtras_Click" />
                            </div>
                        </div>
                    </div>
                </main>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>

