<?php
// Incluir la conexion
require_once 'conexion.php';

session_start();

if (isset($_POST['login'])) {
    $username = $_POST['username'];
    $password = $_POST['password'];


    // Buscar esos datos en la base datos
    $sql = "SELECT id, username from users where username = '$username' and password = '$password' ";

    $resultado = $conexion->query($sql)->fetch();

    if ($resultado) {
        // Iniciar sesion
        $_SESSION['id_user'] = $resultado->id;
        $_SESSION['username_user'] = $resultado->username;

        header("Location: registro_cartas.php");
        exit;
    } else {
        echo "No existe";
    }
}
// Incluir la vista
require_once 'vistas/login.html.php';
