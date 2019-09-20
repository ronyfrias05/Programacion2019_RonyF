<?php

require_once 'conexion.php';

if (isset($_POST['borrar'])) {
    $id = $_POST['id'];

    // Borrado fisico
    // $sql = "DELETE  from cartas where id = $id";

    // Borrado logico
    $sql = "UPDATE cartas SET activo = 0 where id = $id";

    $eliminando = $conexion->exec($sql);
    
    if ($eliminando) {
        echo "Eliminado";
    } else {
        echo "No elimando";
    }

    header("Location: lista_cartas.php");
    exit;
}
