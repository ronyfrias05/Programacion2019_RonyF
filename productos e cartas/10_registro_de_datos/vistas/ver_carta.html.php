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

<body style="background-image: linear-gradient(100deg, #D5DBDB, #FAE5D3 , #D7BDE2, #D4E6F1, #D5DBDB); background-attachment: fixed; background-repeat: no-repeat; background-size: 100vw 100vh;">

    <div class="container my-3 animated fadeInUp" style="border: 3px solid white">
        <div class="row">
            <div class="col-12 col-md-12">
                <img src="<?php echo $carta->link ?>" alt="Url-img..." class="mx-auto mt-3 d-block img-thumbnail" style="width: 40vw; border: 2px solid black">
            </div>
        </div>

        <div class="row">
            <div class="col-md-12 my-5">
                <div class="">
                    <p class="text-center" style="font-size: medium;"><?php echo $carta->name ?></p>
                    <p class="text-primary text-center "><?php echo "$carta->price" . "$"?></p>
                    <a href="lista_cartas.php" class="d-block text-center text-muted text-decoration-none">Volver a la lista cartas</a>
                </div>
            </div>
        </div>
    </div>

</body>

</html>