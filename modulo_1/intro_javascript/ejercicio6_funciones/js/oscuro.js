// Obtener los elementos

var h3 = document.querySelector("h3");
var p = document.querySelector("p");
var a = document.querySelector("a");
var hr = document.querySelector("hr");
var button = document.querySelector("button");
var body = document.querySelector("body");
var claro = document.querySelector(".claro");
var modo = document.querySelector(".modo");
var modoOscuroActivado = false;

// Intercambiar modo
function IntercambiarModo() {
    if (modoOscuroActivado) {
        modoClaro();
    }else {
        modoOscuro();
    }
}

function modoOscuro() {
    h3.style.color = "white";
    p.style.color = "white";
    a.style.color = "white";
    hr.style.borderColor = "white";
    button.style.backgroundColor = "lightblue";

    body.style.backgroundColor = "#353535";

    modoOscuroActivado = true;
    modo.textContent = "Cambiar a modo claro";
}

function modoClaro() {
    h3.style.color = "black";
    p.style.color = "black";
    a.style.color = "red";
    hr.style.borderColor = "blue";
    button.style.backgroundColor = "black";
    button.style.color = "white";

    body.style.backgroundColor = "white";

    modoOscuroActivado = false;
    modo.textContent = "Cambiar a modo oscuro"
}

//modoOscuro();
//document.addEventListener(`click`, modoOscuro);

button.addEventListener(`click`, modoOscuro);

claro.addEventListener(`click`, modoClaro);

modo.addEventListener(`click`, IntercambiarModo);