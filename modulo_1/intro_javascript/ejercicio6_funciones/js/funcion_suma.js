
// var suma = function() {
//     var numero1 = parseInt(prompt("Escriba el numero"));
//     var numero2 = parseInt(prompt("Escriba el numero"));
    
//     var suma = numero1 + numero2;
//     document.write(`<p>El resultado de ${numero1} + ${numero2} es ${suma}.</p>`);
    
// }

var suma = function(n1, n2) { 
    return n1 + n2;
}
var resta = function(n1, n2) { 
    return n1 - n2;
 }

var valor1 = parseInt(prompt("Escriba el primer numero"));
var valor2 = parseInt(prompt("Escriba el segundo numero"));

console.log(suma(valor1, valor2));

