
                <?php 

                    $cantantes = array("Michael Jackson", "Don Carlos", "Eek a Mouse", "Busta Rhymes", "Ariana Grande",);

                    echo "<ol>";
                    echo "<li>{$cantantes[0]}</li>";
                    echo "<li>{$cantantes[1]}</li>";
                    echo "<li>{$cantantes[2]}</li>";
                    echo "<li>{$cantantes[3]}</li>";
                    echo "<li>{$cantantes[4]}</li>";
                    echo "</ol>";

                    // Usando el ciclo for

                    echo "<ol>";
                    for($secuencia = 0; $secuencia <= 4; $secuencia++) {
                        echo "<li>{$cantantes[$secuencia]}</li>";
                    }
                    echo "</ol>";
                    

                    $estudiantesInfotep = [
                        "Alcema Wilben",
                        "Antoine Wentchelle",
                        "Ford Kervens",
                        "Frías Pimentel Rony Rafael",
                        "Gómez Mengo Johanna",
                        "Norbin Waddley Belizaire",
                        "Nunez Ventura Christopher Ramón",
                        "Peralta Rodríguez Linda Carolyn",
                        "Ramos Reyes Ronny Leonardo",
                        "Suarez Fernandez Luis Alberto",
                    ];

                    echo "<h1>Listado de estudiantes</h1>";
                    echo "<ol>";
                    echo "<li>{$estudiantesInfotep[0]}</li>";
                    echo "<li>{$estudiantesInfotep[1]}</li>";
                    echo "<li>{$estudiantesInfotep[2]}</li>";
                    echo "<li>{$estudiantesInfotep[3]}</li>";
                    echo "<li>{$estudiantesInfotep[4]}</li>";
                    echo "<li>{$estudiantesInfotep[5]}</li>";
                    echo "<li>{$estudiantesInfotep[6]}</li>";
                    echo "<li>{$estudiantesInfotep[7]}</li>";
                    echo "<li>{$estudiantesInfotep[8]}</li>";
                    echo "<li>{$estudiantesInfotep[9]}</li>";
                    echo "</ol>";

                    // Usando el ciclo for
                    echo "<h1>Usando ciclo for</h1>";
                    echo "<ol>";
                    for($numero = 0; $numero < 10; $numero++) {
                        echo "<li>{$estudiantesInfotep[$numero]}</li>";
                    }
                    echo "</ol>";

                    // Usando el ciclo foreach
                    echo "<h1>Usando ciclo foreach</h1>";
                    echo "<ol>";
                    foreach($estudiantesInfotep as $numero => $estudiante) {
                        echo "<li>{$estudiante}</li>";
                    }
                    echo "</ol>";

                    // Dias de la semana
                    $dias = [
                        "Lunes",
                        "Martes",
                        "Miercoles",
                        "Jueves",
                        "Viernes",
                        "Sabado",
                        "Domingo",
                    ];

                    foreach($dias as $dia) {
                        echo "<p>$dia</p>";
                    }

                ?>