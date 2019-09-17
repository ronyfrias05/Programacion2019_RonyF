<?php
// Incluir la conexion
require_once 'conexion.php';

try {
    if (isset($_POST['register'])) {
        $name = $_POST['name'];
        $username = $_POST['username'];
        $password = $_POST['password'];


        // Validaciones
        if (empty($name)) {
            throw new Exception("El nombre no puede estar vacio", 1);
        }

        if (empty($username)) {
            throw new Exception("El usuario no puede estar vacio", 2);
        }

        if (empty($password)) {
            throw new Exception("La contraseña no puede estar vacio", 3);
        }

        // Verificar que no exista en la base de datos
        $sql = "SELECT name, username, password from registrar Where username LIKE '%$username%'  ";

        $datos = $conexion->query($sql)->fetchAll();

        if (count($datos) > 0) {
            throw new Exception("Ya existe este nombre. Elija otro", 1);
        }

        // Encriptar la contraña

        $password = password_hash($password, PASSWORD_DEFAULT);

        // Insertar     
        $sql = "INSERT INTO registrar
                (name, username, password)
                VALUES
                (\"$name\", \"$username\", \"$password\")";

        $resultado = $conexion->exec($sql);

        if ($resultado) {
            header("Location: login.php");
            exit;
        } else {
            echo "no se a guardo";
        }
    }
}catch (Exception $e) {
    $error = [
        'codigo' => $e->getCode(),
        'mensaje' => $e->getMessage()
    ];
}

// Incluir la vista
require_once 'vistas/registrar_pagina.html.php';
