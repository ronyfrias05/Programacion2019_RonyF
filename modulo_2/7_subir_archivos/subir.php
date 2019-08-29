<?php 

$error = "";
$mensaje = "";

if (isset($_POST['subir'])) {
    // echo "<pre>";
    // print_r($_FILES);
    // echo "</pre>";

    if (isset($_POST['archivo']) && ($_FILES['archivo']['error']) == 0) {
        $nombre = $_FILES['archivo']['name'];
        $nombre_tmp = $_FILES['archivo']['tmp_name'];
        $tamano = $_FILES['archivo']['size'];

        if (is_uploaded_file($nombre_tmp)) {
            $mensaje= "<div><p>Hemos recibido el archivo</p></div>";

            // Mover el archivo a nuestra carpeta
            $movido = move_uploaded_file($nombre_tmp, "archivos_reicibidos/".$nombre);

            if ($movido) {
                $mensaje = "El archivo se subio correctacmente";
            } else {
                $error = "No se pudo subir correctamente";
            }
        }

    } else {
        $error = "No se ha enviado un archivo";
    }
}

// Incluir la vista
require_once 'archivo.html.php';