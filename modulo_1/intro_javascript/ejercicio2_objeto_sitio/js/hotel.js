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
console.log("Bienvenido al hotel " + hotel.nombre + " que tiene " + hotel.rating + " de rating");n