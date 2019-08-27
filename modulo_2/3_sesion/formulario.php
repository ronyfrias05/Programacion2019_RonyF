<?php
 session_start();
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Formulario</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
</head>

<body>

    <div class="container my-5 border animated fadeInDownBig">
        <form class="" method="post">
            <div class="form-group mt-4">
                <label for="" class="display-4">Publicar</label>
                <input type="text" class="form-control w-50 my-3" aria-describedby="emailHelp" placeholder="Escribe el nombre" name="texto">
                <input type="url" class="form-control w-50 my-3" aria-describedby="" placeholder="URL de la imagen" name="url">
            </div>
                <button type="submit" class="btn btn-outline-secondary my-3" name="guardar">Guardar publicacion</button>
        </form>
        <a href="listado.php">Ir al listado</a>
        <hr>

    <!-- http://www.lorempixel.com/300/300/ -->

    <?php
        if (!isset($_SESSION['publicaciones'])) {
            $_SESSION['publicaciones'] = [];
        }

        if (isset($_POST['guardar'])) {
            $datos = new stdClass();
            $datos->texto = $_POST['texto'];
            $datos->url = $_POST['url'];

            // Agregar los datos a la SESSION
            $resultado = array_push($_SESSION['publicaciones'], $datos);

            if ($resultado) {
                echo "<p class='alert alert-success'>Se agregó</p>";
            } else {
                echo "<p class='alert alert-danger'>No se agregó</p>";
            }
        }

    ?>

</body>
</html>