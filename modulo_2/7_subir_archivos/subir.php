<?php 

$error = "";
$mensaje = "";

if(isset($_POST['subir'])) {
    // echo "<pre>";
    // print_r($_FILES);
    // echo "</pre>";

    if (isset($_FILES['archivo']) && ($_FILES['archivo']['error']) == 0) {
        $nombre = $_FILES['archivo']['name'];
        $nombre_tmp = $_FILES['archivo']['tmp_name'];
        $tamano = $_FILES['archivo']['size'];

        echo "Tamano: " . $tamano;

        $tamano_maximo = 2048; // 2KB

        if ($tamano > $tamano_maximo) {
            $error = "El archivo no puede ser mayor a 2KB";
        }

        if(is_uploaded_file($nombre_tmp)) {
            $mensaje = "<div class='alert alert-success'>Hemos recibido el archivo</div>";

            $directorio = 'archivos_recibidos';

            if(file_exists($directorio)) {
                echo "<div class='alert alert-primary w-75 mx-auto'>El directorio existe</div>";

                // Mover el archivo a nuestra carpeta, tambien sirve para verificar que no suba el archivo si el directorio no existe
                $movido = move_uploaded_file($nombre_tmp, "archivos_recibidos/" .$nombre);

                if($movido) {
                    $mensaje = "<div class='alert alert-success w-75 mx-auto'>El archivo se subio correctamente</div>";
                }else {
                    $error = "<div class='alert alert-success w-75 mx-auto'>No se pudo mover correctamente</div>";
                }
                }else {
                    echo "<div class='alert alert-warning w-75 mx-auto'>El directorio no existe</div>";
                }

        }else {
            $error = "<div class='alert alert-danger w-75 mx-auto'>No se a enviado un archivo</div>";
        }
        
    }else {
        $error = "<div class='alert alert-warning w-75 mx-auto'>No se pudo recibir el archivo</div>";
    }
}

// Incluir la vista
require_once 'archivo.html.php';