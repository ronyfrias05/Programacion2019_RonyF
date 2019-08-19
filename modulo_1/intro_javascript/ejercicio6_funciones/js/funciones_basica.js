saludar();

alert("Hola a todos");

function saludar() {
    alert("Hola de nuevo");
}

function mensaje() {
    document.write(`<h1><i>Esto fue escrito desde JS</i></h1>`);
}

function decirHola(nombre) {
    document.write(`Hola, ${nombre}`);
}

decirHola("Cristian");
decirHola("Suarez");
decirHola("Ford");

mensaje();
mensaje();
mensaje();