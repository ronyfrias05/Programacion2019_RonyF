
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Registro de Instagram</title>
    <link rel="stylesheet" href="bootstrap.min.css">
    <link rel="stylesheet" href="animate.css">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h1 class="animated fadeInLeft">Registro de Instagram</h1>
                <form method="post" class="animated fadeInLeft">
                    <div class="form-group">
                        <input type="text" name="nombre" class="form-control" placeholder="Nombre">
                    </div>

                    <div class="form-group">
                        <input type="text" name="usuario" class="form-control" placeholder="Usuario">
                    </div>

                    <div class="form-group">
                        <input type="password" name="contrasena" class="form-control" placeholder="Contraseña">
                    </div>

                    <div class="form-group">
                        <button type="submit" name="registrar" class="btn btn-primary">Registrar</button>
                    </div>
                </form>

                <?php
                if (!empty($mensaje)) {
                    echo '<div class="alert alert-success animated fadeIn delay-1s">'.$mensaje.'</div>';
                }
                
                if (!empty($error)) {
                    echo '<div class="alert alert-danger animated fadeIn delay-1s">'.$error.'</div>';
                }
                ?>
                
            </div>
            <div class="col-md-6">
                <h2 class="animated fadeInDown">Usuarios registrados</h2>
                <ul>
                
                <?php
                if (isset($datos)){
                    foreach($datos as $dato) {
                        echo "<li class='animated fadeIn delay-1s'>{$dato['nombre']} <b>@{$dato['usuario']}</b></li>";
                    }
                }
                ?>
            

                </ul>
            </div>
        </div>
    </div>
</body>
</html>