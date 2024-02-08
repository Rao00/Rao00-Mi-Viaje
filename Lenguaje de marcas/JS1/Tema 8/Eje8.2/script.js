function addLinea(){
    lista = document.getElementById('lista')
    texto = document.getElementById('textoLinea').value
    lista.innerHTML += '<li>' + texto + '</li>'
}

function removeLinea(){
    debugger
    lista = document.getElementById('lista')
    ultimoHijo = lista.lastChild
    lista.parentNode.removeChild(ultimoHijo)
}