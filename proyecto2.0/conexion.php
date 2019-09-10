<?php

try {
    $DB_HOST = "localhost";
    $DB_NAME = "id10176514_coldsystem";
    $DB_USER = "id10176514_rony";
    $DB_PASS = "rony123";
    $config = [
        PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION
    ];

    $conexion = new PDO("mysql:host=$DB_HOST;dbname=$DB_NAME", $DB_USER, $DB_PASS, $config);
} catch (PDOExeception $pdo) {
    echo $pdo->getMessage();
}