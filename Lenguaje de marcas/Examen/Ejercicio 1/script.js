
var parrafo = document.getElementById('parrafo')
var body = document.getElementById('body')
var wikipedia = document.getElementById('wikipedia')
var google = document.getElementById('google')

var boton1 = document.getElementById('boton1')
var boton2 = document.getElementById('boton2')
var boton3 = document.getElementById('boton3')

boton1.addEventListener('click', event => {
    let numBotones = document.getElementsByTagName('button')
    let numEnlaces = document.getElementsByTagName('a')
    let numTitulos = document.getElementsByTagName('h1')
    parrafo.innerHTML = 'Numero de botones = ' + numBotones.length + '<br>' + 'Numero de enlaces = ' + numEnlaces.length + '<br>' + 'Numero de titulos = ' + numTitulos.length
})

boton2.addEventListener('click', event => {
    let titulo = document.createElement('h1')
    titulo.innerHTML = 'Titulo predetermiando'
    body.appendChild(titulo)
})

boton3.addEventListener('click', event => {
    let wikiTemp = wikipedia.getAttribute('href')
    wikipedia.setAttribute('href', google.getAttribute('href'))
    google.setAttribute('href', wikiTemp)
})