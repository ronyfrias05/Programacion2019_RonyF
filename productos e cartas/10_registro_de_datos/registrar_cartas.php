<?php

session_start();

// Verificar si el usuario esta logeado
if (! isset($_SESSION['id_user'])) {
    header("Location: login.php");
    exit;
}

// Incluir la conexion
require_once 'conexion.php';

try {
    // Guardar los datos
    if (isset($_POST['guardar'])) {
        $nombre = $_POST['name'];
        $url = $_POST['link'];
        $precio = $_POST['price'];

        // Validaciones
        if (empty($nombre)) {
            throw new Exception("El nombre no puede estar vacio", 1);
        }

        if (empty($url)) {
            throw new Exception("El link no puede estar vacio", 2);
        }

        if (empty($precio)) {
            throw new Exception("El precio no puede estar vacio", 3);
        }

        if (intval($precio) < 15) {
            throw new Exception("El precio no puede ser menor que 15", 3);
        }

        // Verificar que no exista en la base de datos
        $sql = "SELECT id, name from cartas Where name LIKE '%$nombre%'  ";

        $datos2 = $conexion->query($sql)->fetchAll();

        if (count($datos2) > 0) {
            throw new Exception("Ya existe este nombre. Elija otro", 1);
        }

        $id_user = $_SESSION ['id_user'];

            // Insertar     
            $sql = "INSERT INTO cartas
                (name, link, price, created_by)
                VALUES
                (\"$nombre\", \"$url\", \"$precio\", \"$id_user\")";

            $resultado = $conexion->exec($sql);

            if ($resultado) {
                $mensaje = "Se guardaron los datos";
                // Limpiar el post
                $_POST = [];
            } else {
                $mensaje = "No se pudieron guardar los datos";
            }
    }    

} catch(Exception $e) {
    $error = [
        'codigo' => $e->getCode(),
        'mensaje' => $e->getMessage()
    ];
}

// Incluir la vista
require_once 'vistas/registrar_cartas.html.php';