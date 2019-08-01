// My banco
alert("Bienvidos a mi banco");

// ENTRADA

var nombre = prompt("Digita tu nombre");
var monto = parseInt( prompt("Digita el monto del prestamo") );
var coutas = parseInt( prompt("Digita en cuantas coutas lo vas a pagar") );
var tasa = parseInt( prompt("Digite la tasa del prestamo") );
var total = 15000;

// PROCESO

var pago = monto / coutas;
var interes = (monto * tasa) / 100;
var total = monto + interes;

// SALIDA
 
alert("EL pago mensual es de: " + pago);
alert("El interes es de: " + interes);
alert("El total a pagar sera de: " + total)
