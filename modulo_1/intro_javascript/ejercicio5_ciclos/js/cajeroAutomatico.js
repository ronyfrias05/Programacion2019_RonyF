alert("Bienvenido a TuCajeroAutomatico Sueco.");

var cliente = {
    nombre: "Arturo",
    apellido: "Perez",
    edad: 25,
    balance: 20000,
    tarjeta: 787896,
    pin: 1122,
    tipoCuenta: "debito", 
}
/*
// 0. Seleccionar idioma
var idioma = prompt("Escriba su idioma, que prefiera:");
while(idioma === null || idioma === ""){
    var idioma = prompt("Escriba su idioma, que prefiera:");
}

// 1. Introducir tarjeta
var tarjeta = prompt("Escriba la tarjeta de 6 digitos, por favor.");
while(tarjeta === null || tarjeta === ""){
    var tarjeta = prompt("Escriba la tarjeta de 6 digitos, por favor.");
}

// Validar que la cantidad de digito sea 6
while(tarjeta.length !== 6 || tarjeta === null || tarjeta === "") {
    tarjeta = prompt("Escriba la tarjeta de 6 digitos, otra vez.");
}
alert("Es una tarjeta de 6 digitos.");

// Validar que la tarjeta ingresada coincida con la mia
var tarjeta = prompt("Introduzca la tarjeta valida:");
while (tarjeta != cliente.tarjeta || tarjeta === null || tarjeta === "") {
    tarjeta = prompt("Introduzca la tarjeta valida, otra vez.");
}
alert("Su tarjeta es valida.");

// 2.  Digitar PIN
var pin = prompt("Escriba su PIN de 4 digitos.");
while(pin === null || pin === "" || pin != cliente.pin){
    pin = prompt("Escriba su PIN de 4 digitos, otra vez.");
}
alert("El pin es valido.");

// 3.  Mostrar opciones
//4. Seleccionar opcion
var retiro = 1,
avance = 2,
chequear_balance = 3,
deposito = 4;

var opcion = prompt(`Seleccione la opciones que desea utilizar: 
    1. Retiro
    2. Avance
    3. Chequear balance
    4. Deposito`);
while(opcion === null || opcion === "" || opcion < 0 || opcion > 5){
        opcion = prompt(`Seleccione la opciones que desea utilizar: 
    1. Retiro
    2. Avance
    3. Chequear balance
    4. Deposito`);
}

// 5.  Seleccionar tipo de cuenta
var tipoDeCuenta = prompt(`Seleccione el tipo de cuenta:
    1. Cuenta de ahorro.
    2. Cuenta corriente.`);
while(tipoDeCuenta != null || tipoDeCuenta != "" || tipoDeCuenta < 0 || tipoDeCuenta > 3){
    tipoDeCuenta = prompt(`Seleccione el tipo de cuenta:
    1. Cuenta de ahorro.
    2. Cuenta corriente.`);  
}

tipoDeCuenta = prompt("Escribe el tipo de cuenta valida:");
while(tipoDeCuenta != null || tipoDeCuenta != "" || tipoDeCuenta != cliente.tipoCuenta){
    tipoDeCuenta = prompt("Escribe el tipo de cuenta valida, otra vez:");
}
alert("La cuenta es valida.");
*/
// 6.  Mostrar opciones de monto
// 7.  Seleccionar monto
var monto1 = 1,
    monto2 = 2,
    monto3 = 3,
    monto4 = 4,
    monto5 = 5,
    monto6 = 6,
    monto7 = 7,
    monto8 = 8;

var opcionesMonto = prompt(`Elija el monto que quiere usar:
    1. 200$
    2. 500$
    3. 1000$
    4. 1500$
    5. 2000$
    6. 2500$
    7. 3000$
    8. Escriba el monto que quiere utilizar...`);
while(opcionesMonto === null || opcionesMonto === NaN || opcionesMonto < 0 || opcionesMonto > 9){
var opcionesMonto = prompt(`Elija el monto que quiere usar:
    1. 200$
    2. 500$
    3. 1000$
    4. 1500$
    5. 2000$
    6. 2500$
    7. 3000$
    8. Escriba el monto que quiere utilizar...`);
}
if(monto8 === "8"){
    prompt("Escriba un monto que quiere utilizar:");
}


// 8.  Mostrar opcion de recibo
var quiereComprobanete = confirm(`¿Desea un comprobante?`);

// 9.  Elegir si o no del comprobate del recibo
if (quiereComprobanete) {
    alert(`Se esta imprimiendo el conprobante`);
}

// 10.  Mostrar mensaje "Retire su dinero" y el dinero sale
alert("Retire su dinreo");

// 11.  Mostrar el mensaje "Retire su tarjeta" y el usuario saca su tarjeta
alert("Retire su tarjeta, por favor");
