// Comentario en linea "//"
/* Comentario en bloque /* */

// alert("Bienvenidos a mi pagina");

// Operciones matematicas
// Declarar variables sin valor, colocamos var y el nombre de la variable
/*
var suma;
var resta;
var multiplicacion;
var division;
*/
// Imprimir variables sin valor
// Cuando una variable no tiene valor, JavaScript nos muestra underfined (no definido)
/*
console.log(suma);
console.log(resta);
console.log(multiplicacion);
console.log(division);
*/
// Asignarle un valor a las variables usando los operadoes matematicos
// NOTA: Cuando ya declaramos variables, no es necesario volver a declararlas
//       para asignarle un valor

//var suma = 1 + 1; Esto no lo hacemos, porque ya esta declarada

// Que es declarar una variable?
/*
console.log(potencia);
*/
// Esto nos dara el siguiente error:
// script.js:24 Uncaught ReferenceError: potencia is not defined
// Para solucionarlo, declaramos la varible

// var potencia;

/* Operaciones sin variables */
/*
console.log("----OPERACIONES SIN VARIABLES---");
console.log(1 + 1);  // Suma
console.log(10 - 3); // Resta
console.log(5 * 5);  // Multiplicacion
console.log(10 / 2); // Division

console.log("----OPERACIONES CON VARIABLES---");
suma = 1 + 1;
resta = 10 - 3;
multiplicacion =  5 * 5;
division = 10 / 2;

console.log(suma);
console.log(resta);
console.log(multiplicacion);
console.log(division);
*/

/* INGRESANDO POR EL USUARIO */
/*
prompt("Digita tu nombre");
prompt("Digita tu ciudad");
prompt("Digita tu edad");
*/
// Ingresado y almacenado

var nombre;
var ciudad;
var edad;

alert("Ahora vamos a pedirte tus datos, es 100% seguro");

nombre = prompt("Digita tu nombre");
ciudad = prompt("Digita tu ciudad");
edad = prompt("Digita tu edad");

console.log(nombre);
console.log(ciudad);
console.log(edad);

alert(nombre);
alert(ciudad);
alert(edad);

document.write(nombre + " " + ciudad + " " + edad);



// Condicionales

    // IF ... ELSE
    /* 
    if(variable_a_conparar>100){
        alert("El valor de la variable es mayor que 100")
    } else if (variable_a_conparar==100){
        alert("El valor de la variable es exactamente 100");
    } else {
        alert("El valor de la variable es menor que 100");
    }
    */

    // SWITCH
    /* 
    switch (variable){
        case(valor1):
        ...enunciados a ejecutar el valor...
        break;
        case(valor2);
        ...enunciados a ejecutar el valor...
        break;
        case(valor3);
        ...enunciados a ejecutar el valor...
        break;
        default:
            ...enunciados a ejecutar cuando el valor no
            coincida con ninguno de los anteriores...
            break;
    }
    */

