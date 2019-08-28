<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Requeride</title>
</head>
<body>
    
<p>Hola, te llamas <?php include('somefile.php'); echo "$nombre $apellido"; ?></p>
<!-- Forma correcta -->
<?php
require('somefile.php');
?>

<!-- Forma coreecta v2 -->
<?php
require 'somefile2.php';
?>

</body>
</html>
