
<?php
// #1 strelen();
echo "<h4>1.Longitud de texto</h4>";
$cadena = "Palabra";
echo strlen ($cadena);
echo "<br>";
$nombre = "Rony";
$longitud = strlen($nombre);
echo "<p>Longitud del nombre <b>$nombre</b> es {$longitud}</p>";

// #2 explode();
echo "<h4>2.Convertir texto a array</h4>";
$cadena = "uno,dos,tres,cuatro,cinco";
$array = explode(",", $cadena);
echo "<br>El número de elementos en el array es: " . count($array);

$frutas = "Manzana Pera Uva Kiwi Limon";
$array2 = explode(" ", $frutas);

echo "<pre>";
print_r($array2);
print_r($array);
echo "</pre>";

// #3 str_split();
echo "<h4>3.Dividiendo el texto</h4>";
$str = "Hello Friend";
echo "<h5>{$str}</h5>";
$arr1 = str_split($str);
$arr2 = str_split($str, 3);

echo "<pre>";
print_r($arr1);
print_r($arr2);
echo "</pre>";

// #4 strtoupper();
echo "<h4>4.Texto a mayuscula</h4>";
echo strtoupper("hola usuario"); //-->HOLA USUARIO --> todo a mayúsculas

// #5 strtolower();
echo "<h4>5.Texto a miniscula</h4>";
echo strtolower("hola USUARIO"); //--> hola usuario --> todo a minúsculas


// strrev
$texto = "Hola mundo";
echo "<br>" . strrev($texto);

$palindromo = "AnitaLavaLaTina";
echo "<br>" . strrev($palindromo);


// similar_text
$hijo1 = "Luis Fernando";
$hijo2 = "Luis Suarez";

$similar = similar_text($hijo1,$hijo2);
echo "<p>Similitud entre textos: $similar</p>";

// ltrim
echo "<h4>Usando ltrim</h4>";
$nombre = "         Rony1";
echo "<pre>" . $nombre . "</pre>";
echo "Con ltrim";
echo "<pre>" . ltrim($nombre) . "</pre>";

// rtrim
echo "<h4>Usando rtrim</h4>";
$nombre ="Rony2        ";
echo "<pre>" . $nombre . "</pre>";
echo "Con rtrim";
echo "<pre>" . rtrim($nombre) . "</pre>";

// trim
echo "<h4>Usando trim</h4>";
$nombre ="        Rony3         ";
echo "<pre>" . $nombre . "</pre>";
echo "Con trim";
echo "<pre>" . trim($nombre) . "</pre>";

// lcfirst

// ucfirst

// 
//
//

