<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Pratica Indice</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
</head>

<body class="container">
    <form class="py-5 px-5 bg-dark" style="margin: 100px 600px 0px 0px;">
        <div class="form-group">
            <label for="exampleInputEmail1" class="text-white">Agrega un Email:</label>
            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp"
                placeholder="Agrega un Email" name="email">
            <small id="emailHelp" class="form-text text-muted">Nunca compartiremos su correo electronico con nadie.</small>
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1" class="text-white">Contraseña:</label>
            <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Contraseña:" name="password">
        </div>
        <div class="form-group form-check">
            <input type="checkbox" class="form-check-input bg-white" id="exampleCheck1" name="exampleCheck1">
            <label class="form-check-label text-white" for="exampleCheck1">Marca esta cajita.</label>
        </div>
        <button type="submit" class="btn btn-primary" id="submit">Enviar</button>
    </form>

   

    <?php

    if (isset($_GET)) {
        $usuario = new stdClass();
        $usuario->correo = $_GET['email'];
        $usuario->contrasena = $_GET['password'];

        echo "<div class='alert alert-success'>";
        echo "<p>Hola, se te enviar un correo a $usuario->correo</p>";
        echo "<p>Tu contraseña es $usuario->contrasena. No la compartas.</p>";
        echo "</div>";
    }

    ?>

    <!-- <script src="js/pratica.js"></script> -->
</body>

</html>