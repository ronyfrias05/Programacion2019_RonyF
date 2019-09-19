<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Registrar cuenta de productos</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.css">
</head>

<body style="background-image: linear-gradient(20deg, #F2D7D5, #F5B7B1 , #D7BDE2); background-attachment: fixed; background-repeat: no-repeat;">

    <div class="container">
        <div class="row my-5 text-center animated fadeIn">
            <!-- Formulario -->
            <form action="" method="post" class="mx-auto p-5 border col-md-6" style="background-color: white;">
                <h3 class="pb-2" style="background: linear-gradient(#F2D7D5, #F5B7B1, #D7BDE2); -webkit-background-clip: text; color: transparent;">Registro de productos</h3>
                <a href="lista_cartas.php" class="text-decoration-none text-secondary">Ver las lista de cartas</a>
                <div class="form-group">
                    <input type="text" name="name" id="name" placeholder="Nombre" class="form-control mt-1" value="<?php if (isset($_POST['name'])) echo $_POST['name']; ?>">
                    <?php
                    if (isset($error) && $error['codigo'] == 1) {
                        echo "<p class='alert alert-danger p-1 my-2'>{$error['mensaje']}</p>";
                    }
                    ?>
                </div>

                <div class="form-group">
                    <input type="url" name="link" id="link" placeholder="Link de la imagen" class="form-control" value="<?php echo $_POST['link'] ?? ''; ?>">
                    <?php
                    if (isset($error) && $error['codigo'] == 2) {
                        echo "<p class='alert alert-danger p-1 my-2'>{$error['mensaje']}</p>";
                    }
                    ?>
                </div>

                <div class="form-group">
                    <input type="number" name="price" id="price" placeholder="Precio" class="form-control" value="<?php if (isset($_POST['price'])) echo $_POST['price']; ?>">
                    <?php
                    if (isset($error) && $error['codigo'] == 3) {
                        echo "<p class='alert alert-danger p-1 my-2'>{$error['mensaje']}</p>";
                    }
                    ?>
                </div>

                <div class="form-group">
                    <input type="submit" name="guardar" value="Guardar" class="btn btn-outline-secondary btn-block mb-2">
                    <a href="logout.php" class="text-decoration-none text-dark">Cerrar sessión</a>
                </div>
            </form>
        </div>
    </div>
    <script src="script.js"></script>
</body>

</html>