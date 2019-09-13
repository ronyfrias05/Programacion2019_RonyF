<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Lista de cartas</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
</head>

<body>

    <div class="container">
        <div class="row mt-3">
            <h3 class="col-md-4 animated slideInDown">Lista de productos</h3>
            <form class="form-inline col-md-4 animated slideInDown" method="get">
                <input class="form-control mr-sm-2" type="search" placeholder="Buscar" aria-label="Search" name="busqueda">
                <button class="btn btn-outline-primary my-2 my-sm-0" type="submit" name="buscar">Buscar</button>
            </form>

            <a href="registrar_cartas.php" class="col-md-4 h3 text-right animated slideInDown">Volver a registrar cartas</a>
            <hr class=" col-md-12 animated fadeIn delay-1s">


            <?php
            // print_r($datos);

            foreach ($datos as $dato) {
                echo '<div class="card col-md-3 animated fadeIn delay-1s m-2">
                            <img src="' . $dato->link . '" alt="" class="card-img-top img-thumbnail mt-3 p-2">
                            <div class="card-body">
                                <h5 class="card-title">' . $dato->name . '</h5>
                                <p class="card-text text-success">$ ' . $dato->price . '</p>
                                <a href="ver_carta.php?id='.$dato->id.'" class="btn btn-outline-primary">Ver producto</a>

                                <form method="post" action="borrar_carta.php">
                                    <input type="hidden" name="id" value="'.$dato->id.'">
                                    <button class="btn btn-outline-danger d-inline-block btn-sm my-2" name="borrar">Borrar</button>
                                </form>
                            </div>
                        </div>';
            }
            ?>
        </div>
    </div>

</body>

</html>