<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Semestral_DS4.Inicio" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Inicio</title>
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
                                <a class="nav-link active" href="Inicio.aspx">Inicio</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="./Productos/ListarProductos.aspx">Inventario</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="./Productos/AgregarProductos.aspx">Agregar Productos</a>
                            </li>
                        </ul>
                    </div>
                </nav>

                <!-- Contenido Principal -->
                <main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">
                    <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                        <h1 class="h2">Bienvenido</h1>
                    </div>

                    <div class="jumbotron bg-light p-4 rounded">
                        <h2>Bienvenido al Sistema de Inventario</h2>
                        <p class="lead">Aquí puedes gestionar los productos, agregar nuevos artículos y administrar todo tu inventario de manera eficiente.</p>
                        <hr class="my-4">
                        <p>Utiliza el menú de navegación para explorar las distintas secciones del sistema.</p>
                        <a class="btn btn-primary btn-lg" href="./Productos/ListarProductos.aspx" role="button">Ver Inventario</a>
                    </div>
                </main>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>