// Operadores Aritmeticos
/*
console.log(2 + 3 - 1);     // 4
console.log(4 * 3 / 2);     // 6
console.log(4 / 3 * 2);     // 2.66...
console.log(11 % 3 ** 2);   // 2
*/

// Ejercicio 1
// Digita 2 numeros y mostra su suma, resta, multiplicacion, division, potencia y residuo.
var numero = parseInt( prompt("Digite su primer numero") );
var numeros = parseInt( prompt("Digite su segundo numero") );

console.log(`El primer numero es ${numero} y el segundo es ${numeros}`);
console.log(`${numero} + ${numeros} = ${numero + numeros}`);
console.log(`${numero} - ${numeros} = ${numero - numeros}`);
console.log(`${numero} * ${numeros} = ${numero * numeros}`);
console.log(`${numero} / ${numeros} = ${numero / numeros}`);
console.log(`${numero} ** ${numeros} = ${numero ** numeros}`);
console.log(`${numero} % ${numeros} = ${numero % numeros}`);

