// Informacion del sitio web
var sitioWeb = {
    titulo: "Bienvenidos a coldChat",
    subtitulo: "comunicacionHelada",
    color:  "azulCeleste",
    tienelogo: true,
    creador: "ronyF y mantecaPlana",
    año: 2019,
    servicios: "cameoFacil",
}

// Cambiar el tutulo de la pagina
document.title = sitioWeb.titulo + " - " + sitioWeb.subtitulo;

// Mostrar informacion del sitio en la pagina
var h1 = document.querySelector("#info");

h1.innerHTML = "Sitio web creado por " + sitioWeb.creador + " en el año " + sitioWeb.año;