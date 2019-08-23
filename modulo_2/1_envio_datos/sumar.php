<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Sumar</title>
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
</head>
<body class="container">
<!-- Hacer un formulario para sumar 2 numeros. -->
    <form action="" method="get" class="border mt-5 mx-5" style="padding: 20px;">
        <div class="row">
            <label for="num1" class="col-auto pt-2">La suma de:</label>
            <input type="number" name="num1" id="suma" class="col-2">
            <label for="num2" class="col-auto pt-2">+</label>
            <input type="number" name="num2" id="suma2" class="col-2">
            <button type="submit" name="sumar" class="btn btn-primary ml-2">Sumar</button>
        </div>
    </form>
</body>
</html>

<?php
if(isset($_POST['sumar'])){
    $num1 = $_GET['num1'];
    $num2 = $_GET['num2'];
    $resultado = $num1 + $num2;
}

    echo "<div class='alert alert-primary mt-2 mx-5'><p>La suma de $num1 + $num2 = $resultado</p></div>"
?>