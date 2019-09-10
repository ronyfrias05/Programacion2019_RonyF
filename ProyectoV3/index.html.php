<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>ProyectoV3</title>
    <link rel="stylesheet" href="css/main.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="fonts/TitilliumWeb-Regular.ttf">
    <script src="js/scrollreveal.min.js"></script>
</head>

<body>
    <!-- NAVBAR -->
    <nav class="navbar navbar-expand-lg navbar-light bg-light sticky-top sticky-top">
        <div class="container">
            <a class="navbar-brand" href="#">ColdSystem</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="#header">Incio</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#info-one">Sobre Mi</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#contact">Enviame un mensaje</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- HEADER -->
    <header id="header">
        <div class="container">
            <div class="row mt-5">
                <div class="col-md-6">
                    <div class="header-content-left">
                        <img src="img/img1.png" alt="CelfonBlanco" style="width: 100%">
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="header-content-right">
                        <h1 class="display-4">Bienvenido a ColdSystem.</h1>
                        <p class="mt-4">En este sitio web podrán tener conexiones con cualquier persona, esta pagina esta en desarrollo, por favor comunicar al desarrollador sobre cualquier fallo.</p>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- TESTIMONIAL -->
    <section id="texto">
        <div class="container">
            <p class="h2 mb-2">Es un conjunto de equipos conectados por medio de cables, señales, ondas o cualquier otro método de transporte de datos, que comparten información (archivos), recursos (CD-ROM, impresoras, etc.) y servicios (acceso a internet, e-mail, chat, ...</p>
            <p class="h4">- Sistemas de redes de computadoras -</p>
        </div>
    </section>

    <!-- INFO ONE -->
    <section id="info-one">
        <div class="container">
            <div class="row mt-5">
                <div class="col-md-6">
                    <div class="info-left">
                        <img src="img/img3.png" alt="celfon2" style="width: 100%">
                    </div>
                </div>
                <div class="col-md-6 my-auto">
                    <div class="info-right">
                        <h4 class="">Sistema de información.</h4>
                        <p class="mt-5"> En informática, los sistemas de información ayudan a administrar, recolectar, recuperar, procesar, almacenar y distribuir información relevante para los procesos fundamentales y las particularidades de cada organización.</p>
                    </div>
                </div>
            </div> 
        </div>
    </section>

    <!-- INFO TWO -->
    <section id="info-two" style="background: rgba(159, 224, 255, 0.2);">
        <div class="container">
            <div class="row my-5">
                <div class="col-md-6">
                    <div class="info-two-bottom my-3">
                        <h2>Desarrollador de esta pagina:</h2>
                        <p>La pagina esta en desarrollo por lo que implica que no esta implementada la Compañía en esta pagina en este sito Web.</p>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="info-two-bottom my-3">
                        <h2>Dato curioso:</h2>
                        <p>JavaScript es un lenguaje de programación interpretado, dialecto del estándar ECMAScript. Se define como orientado a objetos, ​ basado en prototipos, imperativo, débilmente tipado y dinámico.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id="contact">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="formMessage">
                        <form method="post" class="card my-5">
                            <div class="card-body">
                                <div class="form-group">
                                    <input type="text" placeholder="Nombre" class="form-control" name="nombre">
                                </div>
                                <div class="form-group">
                                    <input type="email" placeholder="Email" class="form-control" name="apellido">
                                </div>
                                <div class="form-gruop">
                                    <textarea cols="30" rows="10" placeholder="Mensaje"
                                        class="form-control mb-2" name="mensaje" style="resize: none;"></textarea>
                                </div>
                                <button type="submit" class="btn btn-outline-secondary btn-block" name="enviar">Enviar</button>
                            </div>
                        </form>
                    </div>
                </div>
                <div class="col-md-6 my-auto">
                    <div class="info-three">
                        <h4>Sobre el creador de esta pagina:</h4>
                    <p class="mt-5">Hola, Soy Rony Frias, es un placer que ustedes los usuarios entre a esta pagina para criticar su avance, soy un medio noob en esto de crear pagina, pero con el tiempo ya sabré como hacer que esta pagina contenga lo necesario en cuanto al servicio que ofrece, en el cual se puede comunicar con las demás persona, cuando quieras, en fin, gracias por perder tu tiempo leyendo esto.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <footer>
        <div class="container">
            <div class="row my-2">
                <div class="col-md-12">
                    <div class="copy">
                        <p class="text-center py-5">© Copyright 2019 - Desarrollado por Rony Frias</p>
                    </div>
                </div>
            </div>
        </div>
    </footer>

    <!-- BOOTSTRAP 4 SCRIPT -->
    <script src="js/popper.min.js"></script>
    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <!-- SCRIPTS -->
    <script src="js/main.js"></script>


</body>

</html>
<!-- http://www.lorempixel.com/300/300/ -->