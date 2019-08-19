function cambiarColor() {
    var color = prompt("Digita un color en ingles");

    var body = document.querySelector(`body`);

    body.style.backgroundColor = color;
}

// Preguntar si quiere cambiar el color de la pagina

var deseaCambiar = confirm("¿Desea cambiar el color?");

if (deseaCambiar) {
    cambiarColor();
}

document.addEventListener(`click`, cambiarColor);
document.addEventListener(`keyup`, cambiarColor);