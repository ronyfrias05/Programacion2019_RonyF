window.sr = ScrollReveal();
        sr.reveal('.navbar', {
            duration: 2000,
            origin: 'top'
        });
        sr.reveal('.header-content-left', {
            duration: 2000,
            origin: 'top',
            distance: '100px'
        });
        sr.reveal('.header-content-right', {
            duration: 2000,
            origin: 'right',
            distance: '50px'
        });
        sr.reveal('#texto', {
            duration: 2000,
            origin: 'left',
            distance: '50px',
            viewFactor: 0.2,
        });
        sr.reveal('.info-left', {
            duration: 2000,
            origin: 'left',
            distance: '50px',
        });
        sr.reveal('.info-right', {
            duration: 2000,
            origin: 'right',
            distance: '50px',
        });
        sr.reveal('.info-two-bottom', {
            duration: 2000,
            origin: 'bottom',
            distance: '50px',
        });
        sr.reveal('.formMessage', {
            duration: 2000,
            origin: 'left',
            distance: '50px',
        });
        sr.reveal('.info-three', {
            duration: 2000,
            origin: 'right',
            distance: '50px',
        });
        sr.reveal('.copy', {
            duration: 1000,
            origin: 'bottom',
            distance: '20px',
        });
        

        document.querySelectorAll('a[href^="#"]').forEach(anchor => {
            anchor.addEventListener('click', function (e) {
                e.preventDefault();

                document.querySelector(this.getAttribute('href')).scrollIntoView({
                    behavior: 'smooth'
                });
            });
        });