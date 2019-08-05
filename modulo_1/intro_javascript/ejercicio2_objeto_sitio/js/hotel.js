/*
var nombreHotel = "Domingueros Cold";
var ratingHotel = 5;
var habitacionesHotel = 499;
var reservacionesHotel = 498;
var tieneGymHotel = true;

console.log(nombreHotel);
console.log(ratingHotel);
console.log(habitacionesHotel);
console.log(reservacionesHotel);
console.log(tieneGymHotel);
*/
var hotel = {
    nombre: "Domingueros Cold",
    rating: 5,
    habitaciones: 499,
    reservaciones: 498,
    tieneGym: true,
}

console.log(hotel.nombre);
console.log(hotel.rating);
console.log(hotel.reservaciones);
console.log(hotel.tieneGym);
console.log(hotel.habitaciones);

// Concatenar vs Template string
console.log(`Hola, soy un templete string`);
console.log("Bienvenido al hotel " + hotel.nombre + " que tiene " + hotel.rating + " de rating");

console.log("El hotel tiene " + hotel.reservaciones);
console.log(`El hotel tiene ${hotel.reservaciones}`);

console.log("El hotel tine " + hotel.habitaciones);
console.log(`El hotel tiene ${hotel.habitaciones}`);

console.log("El hotel tiene " + hotel.reservaciones + " de " + hotel.habitaciones + " habitaciones");
console.log(`El hotel tiene ${hotel.reservaciones} de ${hotel.habitaciones} habitaciones`);

console.log("El hotel tiene " + (hotel.habitaciones - hotel.reservaciones) + " habitaciones disponibles");
console.log(`El hotel tiene ${hotel.habitaciones - hotel.reservaciones} habitacionens disponibles`);

console.log(hotel.nombre + " posee un rating de " + hotel.rating + ". Posee " + hotel.habitaciones + ".  Posee " + hotel.reservaciones + ".");
console.log(`${hotel.nombre} posee un rating de ${hotel.rating}. Posee ${hotel.habitaciones}. Posee ${hotel.reservaciones}.`);

// La linea de que esta abajo es un templete string, porque se usa este caracater: (`) y para las variables o expresiones: ${}
console.log(`El hotel tiene ${hotel.habitaciones - hotel.reservaciones} habitaciones disponibles`);

document.write(`<h1>Bienvenidos a ${hotel.nombre}</h1>
<p>Este hotel es de ${hotel.rating} estrellas</p>
<p>Actualmente tenemos ${hotel.habitaciones} de las cuales ${hotel.reservaciones} estan reservadas.</p>`);