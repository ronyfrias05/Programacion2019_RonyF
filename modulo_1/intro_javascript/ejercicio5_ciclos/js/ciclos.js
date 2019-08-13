//  ciclo for
// for (var x=0; x<3; x++) {
//     // alert(x);
//     // prompt("Digite un numero positivo");
// }

// for (var veces = 1; veces<=5; veces++) {
    
//     if(veces == 5){
//         continue;
//     }
    
//     document.write(`<p>Soy un parrafo</p>`);
// }

// var numero = 5;
// while(numero < 10) {
//     console.log("Soy un parrafo");
//     numero++
// }

    var numero = parseInt(prompt("Escribe tu pin"));
while (numero < 0) {
    var numero = parseInt( prompt("Escribe tu pin") );
}
if (numero < 0) {
    alert(`Debe digitar un numero positivo`);
}
alert(`El numero digitado es: ${numero}`);