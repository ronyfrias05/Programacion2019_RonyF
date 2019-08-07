/*
// Ejercicio 1
console.log(`Ejercicio 1`);
var numero1 = parseInt( prompt("Digite su primer numero") );
var numero2 = parseInt( prompt("Digite su segundo numero") );

console.log(`La suma de ${numero1} + ${numero2} = ${numero1 + numero2}`);
console.log(`La resta de ${numero1} - ${numero2} = ${numero1 - numero2}`);
*/
/*
// Ejercicio 2
console.log(`Ejercicio 2`);

var numero3 = parseInt( prompt("Digite su primer numero") );
var numero4 = parseInt( prompt("Digite su segundo numero") );

console.log(`1: suma ${numero3} + ${numero4} = ${numero3 + numero4}`);
console.log(`2: resta ${numero3} - ${numero4} = ${numero3 - numero4}`);
console.log(`3: multiplicacion ${numero3} * ${numero4} = ${numero3 * numero4}`);
console.log(`4: division ${numero3} / ${numero4} = ${numero3 / numero4}`);
*/
/*
// Ejercicio 3
console.log(`Ejercicio 3`);

alert(`Por favor eligir que operacion desea usar
con los numeros indicados respectivamente`);

var usuario = prompt(`1.Suma 2.Resta. 3.Multiplicacion 4.Division`);

var numero5 = parseInt( prompt("Digite su primer numero") );
var numero6 = parseInt( prompt("Digite su segundo numero") );

var suma = 1;
var resta = 2;
var multiplicacion = 3;
var division = 4;

if (usuario == suma) {
    console.log(`la suma de ${numero5} + ${numero6} = ${numero5 + numero6}`);
} else if (usuario == resta) {
    console.log(`la resta de ${numero5} - ${numero6} = ${numero5 - numero6}`);
} else if (usuario == multiplicacion) {
    console.log(`la multiplicacion de ${numero5} * ${numero6} = ${numero5 * numero6}`);
} else if (usuario == division) {
    console.log(`la division de ${numero5} / ${numero6} = ${numero5 / numero6}`);
} else {
    console.log(`Gracias por elegir mi operacion culera xdd`);
}
*/
/*
// Ejercicio 4
console.log(`Ejercicio 4`);

alert(`Hola, bienvenido a Tropicall, por favor completa 
este formulario para trabajar en este departamento.`);

var nombre = prompt("Escriba su nombre aqui");
var trabajado= parseInt( prompt("Cuantas horas quieres trabajar?") );
var pagado = parseInt( prompt("Cuanto quieres que te pague?") );

var personaje = {
    persona: nombre,
    horasTrabajadas: trabajado,
    pagoHora: pagado,
    ganadoHorasTrabajadas: trabajado * pagado,
}

console.log(personaje);
console.log(`Te llamas ${personaje.persona}`);
console.log(`Solicitas estas ${personaje.horasTrabajadas} horas para trabjar.`);
console.log(`Quieres que te paguen este dinero: ${personaje.pagoHora}`);
console.log(`Quieres que te paguen este dinero; ${personaje.ganadoHorasTrabajadas} por 
las horas que solicitas.`);

if (personaje.ganadoHorasTrabajadas <= 2999) {
    console.log(`Gracias por completar el formulario, serás aceptado en 
Tropicall, por favor esperar dentro de ${personaje.horasTrabajadas} meses, 
para comenzar a trabjar en Tropicall.`);
} else {
    console.log(`No serás aceptado/a en Tropicall, ya que exiges mucho dinero.`);
}
*/
/*
// Ejercicio 5
console.log(`Ejercicio 5`);

var numeroPar = parseInt( prompt("Escribe tu numero par aqui") )

if (numeroPar % 2 == 0) {
    console.log(`El numero par introducido es: ${numeroPar}`);
} else {
    console.log(`El numero inpar introducido es: ${numeroPar}`);
}
*/
/*
// Ejercicio 6
console.log(`Ejercicio 6`);

var x = parseInt( prompt(`Escriba su numero`) );

if (x > 0) {
    alert(`Tu numero es positivo ${x}`)
} else if (x < 0) {
    alert(`Tu numero es negativo ${x}`);
}
*/
/*
// Ejercicio 7
console.log(`Ejercicio 7`);

alert(`Hola, queremos saber tu año de nacimineto, para saber tu edad.`)

var nacimiento = parseInt( prompt(`Escribe tu año de nacieminto`) );
var ano = 2019;

alert(`Tu edad es ${ano - nacimiento}`);
*/