
const lista = document.getElementById('lista')
var addLinea = document.getElementById('addLinea') 
var removeLinea = document.getElementById('removeLinea') 


addLinea.addEventListener('click', function()
{
    li = document.createElement('li')
    input = document.getElementById('textoLinea').value
    txt = document.createTextNode(input)
    li.appendChild(txt)
    lista.appendChild(li)
})

removeLinea.addEventListener('click', function(){
    lista.removeChild(lista.lastChild)
})