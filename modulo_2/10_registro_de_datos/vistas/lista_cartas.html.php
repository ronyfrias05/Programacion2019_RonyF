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

<body style="background-image: linear-gradient(200deg, #D5DBDB, #FAE5D3 , #D7BDE2, #D4E6F1, #D5DBDB); background-attachment: fixed; background-repeat: no-repeat;">

    <div class="container">
        <div class="row mt-3">
            <h3 class="col-md-4 animated slideInDown text-secondary">Lista de productos</h3>
            <form class="form-inline col-md-4 animated slideInDown" method="get">
                <input class="form-control mr-sm-2" type="search" placeholder="Buscar" aria-label="Search" name="busqueda">
                <button class="btn btn-outline-secondary my-2 my-sm-0 " type="submit" name="buscar">Buscar</button>
            </form>

            <a href="registrar_cartas.php" class="col-md-4 h3 text-right animated slideInDown text-secondary">Volver a registrar cartas</a>
            <hr class=" col-md-12 animated fadeIn delay-1s">


            <?php
            // print_r($datos);

            foreach ($datos as $dato) {
                echo '<div class="card col-md-3 animated fadeIn delay-1s m-2" style="background: none; border: 3px solid white;">
                            <img src="' . $dato->link . '" alt="" class="card-img-top img-thumbnail mt-3 p-2">
                            <div class="card-body">
                                <h5 class="card-title text-secondary">' . $dato->name . '</h5>
                                <p class=" text-muted card-text">Creado por: '.$dato->created_by.'</p>
                                <p class="card-text text-primary">$ ' . $dato->price . '</p>
                                <a href="ver_carta.php?id='.$dato->id.'" class="btn btn-outline-dark">Ver producto</a>

                                <form method="post" action="borrar_carta.php" class="">
                                    <input type="hidden" name="id" value="'.$dato->id.'">
                                    <button class="btn btn-outline-secondary d-inline-block btn-sm my-2" name="borrar">Borrar</button>
                                </form>
                            </div>
                        </div>';
            }
            ?>
        </div>
    </div>

</body>

</html>