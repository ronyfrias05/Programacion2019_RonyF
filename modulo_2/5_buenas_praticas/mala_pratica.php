<?php

if (isset($_POST['verifiacar'])) {
    $edad = $_POST['edad'];

    if ($edad >= 18) {
        echo "<p>Bienvenido</p>";
    } else {
        echo "<p>No puedes ver este sitio</p>";
    }
}

?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Formulario</title>
</head>
<body>
    <form action="" method="post">
        <input type="text" name="edad">
        <button type="submit" name="verificar">Verificar</button>
    </form>
</body>
</html>