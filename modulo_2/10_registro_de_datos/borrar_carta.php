<?php

require_once 'conexion.php';

if (isset($_POST['borrar'])) {
    $id = $_POST['id'];

    $sql = "DELETE  from cartas where id = $id";

    $eliminando = $conexion->exec($sql);
    
    if ($eliminando) {
        echo "Eliminado";
    } else {
        echo "No elimando";
    }

    header("Location: lista_cartas.php");
    exit;
}
