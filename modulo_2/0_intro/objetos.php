<?php

// Objeto
$persona = new stdClass();
$persona->nombre = "Rony";
$persona->edad = 23;
$persona->estaCasado = false;

if($persona->edad >= 18){
    echo "$persona->nombre es mayor de edad";
} else {
    echo "$persona->nombre es menor de edad";
}

?>