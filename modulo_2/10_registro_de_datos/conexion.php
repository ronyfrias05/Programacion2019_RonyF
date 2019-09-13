<?php

try {
    $DB_HOST = "localhost";
    $DB_NAME = "productos";
    $DB_USER = "root";
    $DB_PASS = "";
    // $config = [
    //     PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION
    // ];

    $config = [
        3 => 2, // Lanzar  execepiones como errores
        19 => 5, // Traer los datos en forma de objetos
    ];

    $conexion = new PDO("mysql:host=$DB_HOST;dbname=$DB_NAME", $DB_USER, $DB_PASS, $config);
} catch (PDOExeception $pdo) {
    die(  $pdo->getMessage() );
}