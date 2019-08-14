// Ejercicio 1
// Hacer una sume de numeros positivos.
// Validar que el usuario no pueda ingresar numeros negatios.
/*
var num1 = parseInt( prompt("Escriba su primer numero.") );
while (num1 < 0) {
    num1 = parseInt( prompt("vuelve a escrbir tu primer numero, lo escribiste en negativo.") );
    num1++;
}

var num2 = parseInt( prompt("Escriba su segundo numero.") );
while (num2 < 0) {
    var num2 = parseInt( prompt("vuelve a escrbir tu segundo numero, lo escribiste en negativo.") );
    num2++;       
}
    
var resultado = num1 + num2;
alert(`La suma de ${num1} + ${num2} = ${resultado}`)

// Ejercicio 2
// Hacer un progreama para ditiar una edad.
// La edad solo debe estar entre 18 y 25.

alert(`Si eres tines mas 18, pero no te pasas de 25, entonces 
puede entrar al concurso de "Los quimicos elegantes",
escribe tu edad en el siguiente cuadro...`);

var edad = parseInt( prompt("Escriba su edad aqui:") );

while (edad < 18 || edad > 25) {
    edad = parseInt( prompt("Eres menor de edad o eres muy viejo, escribe la edad indicada:") );
}

alert(`Puedes participar en ${edad} dias, porqué tienes ${edad} años.`);

// Ejericicio 3
// Hacer un progrema que se digite un PIN de 4 digito.
// Validar que el PIN digitado tenga 4 caracteres.

var pin = prompt("Digite su pin que tenga 4 digitos:");
while (pin.length != 4) {
    if (pin.length != 4) {
        alert("PIN invalido");
    } else {
        alert("PIN valido.");
    }
    pin = prompt("Digite su pin que tenga 4 digitos, correctamente:");
}

// Ejercicio 4
// Hacer un programa que el usuario no pueda ingresar numeros entre 70 y 99.

var num3 = parseInt( prompt("Escribe numeros que no esten entre 70 y 99:") );
while(num3 > 70 || num3 > 99){
    num3 = parseInt(prompt("Escribe numeros que NO esten entre 70 y 99:"));
}

// Ejercicio 5
// Hacer un programa que el usuario deba digitar un monto valido para abrir su cuenta de banco, este monto es 600 pesos.

var monto = parseInt( prompt("Escriba el monto:") );
while (monto < 600) {
    monto = parseInt(prompt("Escriba el monto, otra vez:"));
}
alert("Bienvenido a su cuenta nueva.");

// Ejericio 6
// Hacer un programa que se digite una edad valida para entrar a INFOTEP.

var edadInfotep = parseInt(prompt("Escriba la edad, debes tener mas de 18 años:"));
while(edadInfotep < 18){
    edadInfotep = parseInt(prompt("Escriba su edad valida para entrar a INFOTEP"));
}
alert("Bienvenidos a INFOTEP");

// Ejericio 7
// Hacer un programa para validar una contraseña. Debe tener como minimo 8 caracteres.

var contrasena = prompt("Escriba la contraseña:");
while(contrasena.length < 8){
    contrasena = prompt("Escriba la contraseña, que contenga mas de 8 caracteres:");
}
alert("La contraseña es correcta.");

// Ejericio 8
// Hacer un programa que solo digite numeros negativos.

var numNegativos = parseInt(prompt("Escribe los numeros negativos:"));
while (numNegativos > 0) {
    numNegativos = parseInt(prompt("Escribe los numeros negativos:"));
}
alert("El numero es negativo.");

do {
    numNegativos = parseInt(prompt("Escribe los numeros negativos:"));
} while (numNegativos > 0);
alert("El numero es negativo.");

// Ejercicio 9
// Hacer un programa que se digite solo numeros positivos.

do {
    var numPositivo = parseInt(prompt("Escribe numeros positivos y par:"));
} while (numPositivo < 0 || numPositivo % 2 === 1);
alert("El numero es positivo y es par.");

do {
    var numPositivo = parseInt(prompt("Escribe numeros positivos y par:"));
} while( !(numPositivo > 0 && numPositivo % 2 === 0) );
alert("El numero es positivo y es par.");
*/
var pass = prompt("Escribe la contraseña:");
var pass1 = prompt("Escribe la contraseña otra vez:");
while(pass !== pass1){
    pass = prompt("Escribe la contraseña que coincidan:");
    pass1 = prompt("Escribe la contraseña que coincidan otra vez:");
}
alert("La contraseña son indenticas.");