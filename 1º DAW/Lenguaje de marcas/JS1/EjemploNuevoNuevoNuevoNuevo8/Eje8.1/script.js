
var botonCa = document.getElementById('cabeceraB')
var botonIm = document.getElementById('imagenB')
var botonPa = document.getElementById('parrafoB')

botonCa.addEventListener('click', event => {changeCabecera()})
botonIm.addEventListener('click', event => {changeImg()})
botonPa.addEventListener('click', event => {changeParrafo()})

function changeCabecera(){
    var cabecera = document.getElementById('cabecera')
    cabecera.innerHTML = 'Titulo Cambiado'
}

function changeImg(){
    var img = document.getElementById('imagen')
    img.src = "Carola.jpg"
}

function changeParrafo(){
    var cabecera = document.getElementById('parrafo')
    cabecera.innerHTML = 'Parrafo cambiado'
}