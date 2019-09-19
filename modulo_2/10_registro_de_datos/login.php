<?php

session_start();

// Verificar si el usuario ya esta logeado
if (isset($_SESSION['id_user'])) {
    header("Location: lista_cartas.php");
    exit;
}

require_once 'conexion.php';

try {
  
} catch (PDOException $x) {
  die($x->getMessage);
} catch (Exception $e) {
  $error = [
        'codigo' => $e->getCode(),
        'mensaje' => $e->getMessage()
    ];
}

if (isset($_POST['login'])) {
  $username = $_POST['username'];
  $password = $_POST['password'];

  // Buscar esos datos en la base de datos
  $sql = "SELECT id, name, username, password FROM users 
          WHERE username = '$username' ";

  $resultado = $conexion->query($sql)->fetch();

  if ($resultado) {
    // Comparar la contraseña encriptada
    if (! password_verify($password, $resultado->password)) {
      header("Location: login.php");
      exit;
    }


    // Iniciar sesion
    $_SESSION['id_user'] = $resultado->id;
    $_SESSION['name_user'] = $resultado->name;

    header("Location: registrar_cartas.php");
    exit;
    
  } else {
    echo "No existe";
  }

}

// Incluir la vista
require_once 'vistas/login.html.php';