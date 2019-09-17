<!doctype html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Iniciar Sesión</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
</head>

<body>
    <div class="container">
        <div class="row">
            <form class="form-signin my-5 border rounded col-md-5 mx-auto" method="post">
                <div class="text-center mb-4">
                    <img class="my-3" src="img/img.svg" alt="" width="72" height="72">
                    <h1 class="h3 mb-3 font-weight-normal">Iniciar Sesión</h1>
                    <p>Inicia sección para un uso mas dinamico en la pagina.</p>
                </div>

                <div class="row">
                    <div class="form-label-group col-md-10 mx-auto">
                        <input type="text" class="form-control" placeholder="Nombre de usuario" requerid name="username">
                    </div>
                </div>

                <div class="row">
                    <div class="form-label-group col-md-10 mx-auto my-3">
                        <input type="password" class="form-control" placeholder="Contraseña" required name="password">
                    </div>
                </div>

                <div class="row">
                    <button class="btn btn-md btn-outline-primary btn-black col-md-9 mx-auto" type="submit" name="login">Iniciar sesión</button>
                </div>

                <div class="row">
                    <a href="registrar_pagina.php" class="mx-auto text-center col-md-9 my-1 text-decoration-none">Registrarse</a>
                </div>

                <p class="mt-2 mb-3 text-muted text-center">&copy; 2017-2019</p>
            </form>
        </div>
    </div>
</body>

</html>