<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Ver carta</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
</head>

<body>

    <div class="container">
        <div class="row ">
            <div class="col-md-12">
                <img src="<?= $carta['link'] ?>" alt="imagen">
            </div>
        </div>

        <div class="row">
            <div class="col-md-12 my-5">
                <div class="">
                    <h2 class="display-4"><?= $carta['name']?></h2>
                    <p class="text-success">Precio</p>
                    <p class="">Esta es una descripcion</p>
                    <a href="lista_cartas.php" class="btn btn-outline-secondary">Volver a la lista cartas</a>
                </div>
            </div>
        </div>
    </div>

</body>

</html>