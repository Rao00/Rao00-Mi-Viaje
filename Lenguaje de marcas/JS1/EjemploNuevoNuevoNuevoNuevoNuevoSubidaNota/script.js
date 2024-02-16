
cambiarTexto = document.getElementById('cambiarTexto')
borrarFila = document.getElementById('borrarFila')
addFila = document.getElementById('addFila')
texto = document.getElementById('texto').text
table = document.getElementById('tabla')

/*cambiarTexto.addEventListener()
borrarFila.addEventListener()*/
addFila.addEventListener('click', event => {addRow()})

function addRow(){
    let fila = document.createElement('tr')
    let columna = document.createElement('td')
    let parrafo = document.createElement('p')
    let numColumns = prompt('Ingresa el numero de columnas')
    
    for(let i = 0; i < numColumns; i++){
        parrafo = document.createTextNode(texto)
        columna.appendChild(parrafo)
        fila.appendChild(columna)
    }
    table.appendChild(fila)
}