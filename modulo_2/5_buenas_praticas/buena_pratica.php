<?php

$mensaje = "";

if (isset($_POST['verifiacar'])) {
    $edad = $_POST['edad'];

    if ($edad >= 18) {
        $mensaje = "<p>Bienvenido</p>";
    } else {
        echo "<p>No puedes ver este sitio</p>";
    }
}

require_once 'edad.html.php';

?>