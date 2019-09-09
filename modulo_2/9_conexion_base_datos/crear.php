<?php

require_once "conexion.php";
/*
$sql = "CREATE TABLE usuario (
    id INT UNSIGNED AUTO_INCREMENT,
    nombre VARCHAR(100),
    usuario VARCHAR(50),
    contrasena VARCHAR(80),

    PRIMARY KEY(id)
)";

$sql = 'INSERT INTO usuario
    (nombre, usuario, contrasena)
    VALUES
    ("Frias", "freezer","123456"),
    ("Criss", "ben10", "78456")
';

$sql = 'UPDATE usuario
        SET nombre = "la_melma_insaciable"
        WHERE id = 1';

$sql = 'DELETE FROM usuario
        WHERE id = 6';

$sql = 'INSERT INTO usuario
        (nombre, usuario, contrasena)
        VALUES
        ("Juaquin", "Sole", "854541"),
        ("Manuela", "Marquez", "445645"),
        ("Martina", "Campos", "154465")';
        */

$conexion->exec($sql);