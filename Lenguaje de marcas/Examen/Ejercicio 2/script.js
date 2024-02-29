
var boton1 = document.getElementById('boton1')
var body = document.getElementById('body')


boton1.addEventListener('click', event => {
    let parrafos = document.getElementsByTagName('p')
    if (parrafos.length > 0){
        for(let i = parrafos.length-1; i >= 0; i--){
            body.removeChild(parrafos[i])
        }
    }
    let numMaximo = 30
    let num
    num = Math.floor(Math.random()*numMaximo)
    alert(num)
    for(let i = 0; i < num; i++){
        let parrafo = document.createElement('p')
        parrafo.innerHTML = 'Este es el parrafo ' + (i+1)
        body.appendChild(parrafo)
    }
})