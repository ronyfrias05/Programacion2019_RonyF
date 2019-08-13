
// Ejercicio 1
// Digitar la base y la altura de un triangulo y calcular e imprimir la hipotenusa.
var altura = parseInt( prompt("Escriba la altura del triangulo") );
var base = parseInt( prompt("Escriba la base del triangulo") );
var potencia1 = altura ** 2;
var potencia2 = base ** 2;
var raiz = potencia1 + potencia2;
var resultado = Math.pow(raiz,0.5).toFixed(0);

// h^2 = a^2 + b^2

console.log(`Por el teorema de Pítagoras,

h² = a² + b²
h² = ${altura}² + ${base}²
h² = ${potencia1 } + ${potencia2}
h² = ${potencia1 + potencia2}

Como la hipotenusa esta al cuadrado, se calcula
la raíz cuadrada:

h² = ${potencia1 + potencia2}
h = √${raiz}
h = ${resultado}

La hipotenusa mide ${resultado}cm.`);

// Ejercicio 2
// Digitar 4 notas y calcular e imprimir el promedio.

alert(`Hola, a continación escriba las 4 notas de su escuela primaria.`);

var nota1 = parseInt( prompt("Escriba su primera nota") ),
    nota2 = parseInt( prompt("Escriba su segunda nota") ),
    nota3 = parseInt( prompt("Escriba su tercera nota") ),
    nota4 = parseInt( prompt("Escriba su cuarta nota") ),
    notaResultado1 = nota1 + nota2 + nota3 + nota4,
    notaResultado2 = notaResultado1 / 4;

alert(`El promedio de sus notas es: ${notaResultado2}`);

// Ejercicio 3
// Calcular la distancia recorrida.
// Formula de la distancia: d = v * t

var tiempo = 25,
    velocidad = 100;

alert(`El tiempo establecido es de: ${tiempo}s.
La velocidad establecida es de: ${velocidad}m/s.

La distancia recorrida es de: ${velocidad * tiempo}km.`);

// Ejercicio 4
// Calcular la hipotenusa de un triangualo

var base2 = 4,
    altura2 = 3,
    hipotenusa2 = 5;

alert(`Calculando una hipotenusa:
b = ${base2}
a = ${altura2}
c = ${hipotenusa2}

La formula seria la siguiente: a²+b²=c²
Realizamos la operación:
(${altura2})²+(${base2})²=(${hipotenusa2})²
${altura2 ** 2}+${base2 ** 2}=${hipotenusa2 ** 2}
${altura2 ** 2 + base2 ** 2}=${hipotenusa2 ** 2}`);

// Ejercicio 5
// imprimir los numeros del 1 al 100

for (i = 1; i <= 100; i++) {
    document.write(i + "<br>");
}

// Ejercicio 6
// Digitar el año de naciemiento e imprimir la edad actual
alert(`Para saber su edad, escriba el año en el siguiente cuadro...`);

var naciemiento = parseInt( prompt(`Escriba su año de nacimento aqui:`) );

if (naciemiento > 0) {
    alert(`Su edad es: ${2019 - naciemiento}`);
} else {
    alert(`Por favor no poner su año en negativo... Repita el proceso con F5.`);
}

// Ejercicio 7
// Digitar un numero y mostrar que dia de la semana
// es. Validar que no se pueda digitar un numero que
// no sea mayor que 7 o menor que 1.

var dia = parseInt( prompt(`Escriba un dia de la semana del 1 al 7.`) );

while(dia > 1, dia < 7) {
    dia = parseInt( prompt(`Escriba un dia de la semana del 1 al 7.`) );
}

if (dia === 1) {
    alert(`El dia que escribio, es el Domingo.`);
} else if (dia === 2) {
    alert(`El dia que escribio, es el Lune.`);
} else if (dia === 3) {
    alert(`El dia que escribio, es el Marte.`);
} else if (dia === 4) {
    alert(`El dia que escribio, es el Miercole.`);
} else if (dia === 5) {
    alert(`El dia que escribio, es el Jueve.`);
} else if (dia === 6) {
    alert(`El dia que escribio, es el Vierne.`);
} else if (dia === 7) {
    alert(`El dia que escribio, es el Sabado.`);
}

// Ejercicio 8
// Digitar un numero y mostrar que mes del año es.
// Validar que no se puede digitar un numero que no
// sea mayor que 12 o menor que 1.

var mes = parseInt( prompt(`Escriba un mes del año del 1 al 12.`) );

if (mes === 1) {
    alert(`El mes 1 del año, es el Enero.`);
} else if (mes === 2) {
    alert(`El mes 2 del año, es el Febrero.`);
} else if (mes === 3) {
    alert(`El mes 3 del año, es el Marzo.`);
} else if (mes === 4) {
    alert(`El mes 4 del año, es el Abril.`);
} else if (mes === 5) {
    alert(`El mes 5 del año, es el Mayo.`);
} else if (mes === 6) {
    alert(`El mes 6 del año, es el Junio.`);
} else if (mes === 7) {
    alert(`El mes 7 del año, es el Julio.`);
} else if (mes === 8) {
    alert(`El mes 8 del año, es el Agosto.`);
} else if (mes === 9) {
    alert(`El mes 9 del año, es el Septiembre.`);
} else if (mes === 10) {
    alert(`El mes 10 del año, es el Octubre.`);
} else if (mes === 11) {
    alert(`El mes 11 del año, es el Noviembre.`);
} else if (dia === 12) {
    alert(`El mes 12 del año, es el Diciembre.`);
}

// Ejercicio 9
// Digitar un numero y decir si es par o impar.

var par = parseInt( prompt(`Escriba su numero par o impar`) );

if (par % 2 === 0) {
    alert(`Su número es par.`);
} else {
    alert(`Su número es inpar.`);
}

// Ejercicio 10
// Imprimir los numero pares del 1 al 100.

for (I = 2; I <= 100; I+=2) {
    document.write(I + "<br>");
}

// Ejercicios extras :v
// Mostrar los numeros pares, impares del 1 al 50.

alert("Ejercicio extra 1");
for (a = 1; a <= 50; a+=2) {
    if (a != 0) {
        document.write(`${a + 1} par <br>`);
    }
    document.write(a + "Inpar" + "<br>");
}

// Digitar un numero primo.

alert("Ejercicio extra 2");

var primo = parseInt( prompt(`Escribe tu numero primo`) ),
    j = 100;

if (1 === false && primo < j) {
        alert(`El numero ${primo} es primo.`);
} else {
        alert(`El numero ${primo} No es primo.`);
}