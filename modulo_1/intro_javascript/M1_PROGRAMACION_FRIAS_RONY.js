// Hola, soy Rony Frias, aqui muestro en pantalla con un alert, usando mi nombre.
alert("By Rony Frias");
// El siguiente alert, lo utilizo para decirle al usuario una explicacion del programa basico.
alert("Es un programa basico, que le permite al usuario hacer operaciones basicas.");

// Aquí almaceno la variable(var) con el valor de "nombre", esto me permite almacenar el valor, lo puedo utilizar y modificar
// la veces que quiera.
// var = varible
// valor de la variabnle = solo texto, caracteres especiales y no llevar numeros al principio del valor.
var nombre = prompt("Escriba su nombre:");

// while = bucle repetito, dentro de este se usa una condicion.
// La condiciones o operaiones de conparacion pueden ser: < , > , <= , >= ,etc...
while(nombre == null){
    nombre = prompt("Escriba su nombre:");
}
// Muestro un mensaje.
alert(`Hola ${nombre}, continuemos con el programa.`);

// Aquí utilizo una variable con el valor de edad.
// el parametro "prompt" lo utilizo para imprimir en pantalla y mostrar un mensaje.
var edad = parseInt( prompt("Escriba su edad:") );

// Uso el while para validar que sea menor o igual que 1, lo mismo, mayor o igual a 120.
while(edad <= 1 || edad >= 120){
    edad = parseInt(prompt("Escriba su edad, otra vez:"));
}
// Muestro un mensaje
alert(`Tu tienes ${edad} años.`)

// Imprimo un mensaje y escribo por pantalla
var  numero1 = parseInt( prompt("Escriba el primer número:") );
var  numero2 = parseInt( prompt("Escriba el segundo número:") );

// Valido que no se escriba 0
while(numero2 === 0){
    alert("Todo numero que se divide a 0 no es posible.");
    numero2 = parseInt(prompt("Escriba el segundo número:"));
}

// Imprimo un mensaje y escribo por pantallla
var  lista = parseInt( prompt(`Operaciones basicas, escriba el número
de las siguientes opciones:
1. Suma.
2. Resta.
3. Multiplicación.
4. División.`) );

// Aquí uso un while para validar que sea menor que 0 y mayor que 5
while(lista < 0 || lista > 5){
    alert("Tiene que ser del 1 al 4, para realizar las operaciones siguientes.")
    lista = parseInt(prompt(`Operaciones basicas, escriba el número
de las siguientes opciones:
1. Suma.
2. Resta.
3. Multiplicación.
4. División.`));
}

// Aquí le aplico una condicion, en español, if ="si" , else = "pero".
if (lista === 1) {
    alert(`La suma de ${numero1} + ${numero2} = ${numero1 + numero2}`);
} else if (lista === 2) {
    alert(`La resta de ${numero1} - ${numero2} = ${numero1 - numero2}`);
} else if (lista === 3) {
    alert(`La multiplicación de ${numero1} * ${numero2} = ${numero1 * numero2}`);
} else if (lista === 4) {
    alert(`La división de ${numero1} / ${numero2} = ${numero1 / numero2}`);
}

// Le pregunto al usuario si quiere ver la tabla de multiplicacion o solo la despedida del usuario.
var pregunta = confirm("Desea ver la tabla de multiplicar su edad");
if(pregunta == true){
    alert(`La tabla de multiplicar para su edad
1 x ${edad} = ${1 * edad}
2 x ${edad} = ${2 * edad}
3 x ${edad} = ${3 * edad}
4 x ${edad} = ${4 * edad}
5 x ${edad} = ${5 * edad}
6 x ${edad} = ${6 * edad}
7 x ${edad} = ${7 * edad}
8 x ${edad} = ${8 * edad}
9 x ${edad} = ${9 * edad}
10 x ${edad} = ${10 * edad}
11 x ${edad} = ${11 * edad}
12 x ${edad} = ${12 * edad}

Gracias por usar mi pragrama de operaciones basicas ${nombre}.`);
} else if(pregunta == false){
    alert(`Gracias por usar mi pragrama de operaciones basicas ${nombre}.`);
}
