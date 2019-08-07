// Validaciones

var validaciones = {
    nombre: prompt("Escribe tu nombre"),
    año: parseInt( prompt("Escribe tu año de nacimineto") ),
}

var edad = 2019 - validaciones.año;

if (validaciones.año > 0) {
    console.log(`Te llamas ${validaciones.nombre} y tienes ${edad} años.`);
} else {
    console.log(`No eres permitido`);;
}

