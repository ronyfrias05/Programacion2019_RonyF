<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Registrar</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
</head>
<body style="background-image: linear-gradient(20deg, #D6EAF8, #D4E6F1, #E8DAEF); background-attachment: fixed; background-repeat: no-repeat; background-size: 100vw 100vh;">
    <div class="container">
        <div class="row">
            <form class="form-signin my-3 border rounded col-md-5 mx-auto animated bounceIn" method="post" style="background-color: white;">
                <div class="text-center mb-4">
                    <img class="my-3" src="img/img.svg" alt="" width="72" height="72">
                    <h1 class="h3 mb-3 font-weight-normal" style="background: linear-gradient(#51ECFF, #5CCEFF, #5CB2FF); -webkit-background-clip: text; color: transparent;">Registrar usuario</h1>
                    <p>Registrate para poder usar todos nuestro servicios.</p>
                </div>

                <div class="row">
                    <div class="form-label-group col-md-10 mx-auto">
                        <input type="text" class="form-control" placeholder="Nombre" requerid name="name">
                    </div>
                </div>

                <div class="row">
                    <div class="form-label-group col-md-10 mx-auto my-3">
                        <input type="text" class="form-control" placeholder="Nombre de usuario" requerid name="username">
                    </div>
                </div>

                <div class="row">
                    <div class="form-label-group col-md-10 mx-auto mb-3">
                        <input type="password" class="form-control" placeholder="Contraseña" required name="password">
                    </div>
                </div>

                <div class="row">
                    <button class="btn btn-outline-secondary col-md-9 mx-auto" type="submit" name="register">Registrarse</button>
                </div>

                <div class="row">
                    <a href="login.php" class="mx-auto text-center col-md-9 my-1 text-decoration-none text-info" >Iniciar sesión</a>
                </div>

                <p class="mt-5 mb-3 text-muted text-center">&copy; 2017-2019</p>
            </form>
        </div>
    </div>

</body>
</html>