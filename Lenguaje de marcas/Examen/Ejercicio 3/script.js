
var body = document.getElementById('body')
var colorRojo = 'red'
var colorAzul = 'blue'
var started = false
var intervalo

function cambiarColor(){
    if (body.style.backgroundColor == colorRojo){
        body.style.backgroundColor = colorAzul
    }
    else{
        body.style.backgroundColor = colorRojo
    }
}

var boton1 = document.getElementById('boton1')
var boton2 = document.getElementById('boton2')

boton1.addEventListener('click', event => {
    if (!started){
        started = true
        intervalo = setInterval(cambiarColor, 1000)
    }
})

boton2.addEventListener('click', event => {
    if(started){
        started = false
        clearInterval(intervalo)
    }
})
