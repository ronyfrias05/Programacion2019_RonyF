<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Asociativo</title>
    <link rel="stylesheet" href="bootstrap.css">
</head>
<body>

    <?php 
    
    // Listados de carros
    $carros = array("Lambo", "Toyota", "Ford");

    echo $carros[2];

    // Numero
    $numeros = [
        "edad" => 14,
        "anos" => 5
    ];

    echo $numeros["anos"];

    // Estudiantes
    $estudiantes = [
        "nombre" => "Criss",
        "edad" => 23,
        "estaCasado" => false,
        "tieneCelular" => true
    ];

    echo "<p>{$estudiantes['nombre']} tiene {$estudiantes['edad']}</p>";

    // Mezclado

    $mezcla = [
        'nombre' => "criss",
        "edad" => 23,
        5 => 15,
        6 => 30,
        1 => 5
    ];

    echo $mezcla["nombre"];
    echo $mezcla[5];
    echo $mezcla[6];

    /*
    echo "<pre>";
    print_r($mezcla);
    print_r($estudiantes);
    print_r($carros);
    echo "</pre>";
    */

    $hermanos = array("Jonathan", "Anthony", "Alex");
    echo $hermanos[0];
    echo $hermanos[2];
    echo $hermanos[1];

    $hermanos = [
        "primero" => 'Jonathan',
        "segundo" => 'Alex',
        "tercero" => 'Anthony'
    ];

    echo $hermanos["primero"];
    echo $hermanos["segundo"];
    echo $hermanos["tercero"];

    //echo $hermanos; Esta forma es  incorrecta
    echo("<pre>");
    print_r($hermanos);
    echo("</pre>");



    ?>
    
</body>
</html>