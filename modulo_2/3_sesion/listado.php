<?php
    session_start();

    // $_SESSION = [];
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Listado</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
</head>
<body>
    
    <div class="row">
    <?php 
        // Recorrer las publicaciones
            if (isset($_SESSION['publicaciones'])) {
                foreach ($_SESSION['publicaciones'] as $publicacion) {
                    echo "<div class='col-md-4 border my-5 container'><img src='{$publicacion->url}' class='img-thumbnail w-100 my-3 animated fadeIn' alt='imagen' style='width: 100%'><p class=' text-center'>{$publicacion->texto}</p></div>";
                }        
            }
    ?>
    </div>

</body>
</html>
