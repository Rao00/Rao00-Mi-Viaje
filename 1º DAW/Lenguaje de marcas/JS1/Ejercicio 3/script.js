
cambiarTexto = document.getElementById('cambiarTexto')
borrarFila = document.getElementById('borrarFila')
addFila = document.getElementById('addFila')
texto = document.getElementById('texto')
table = document.getElementById('tabla')


addFila.addEventListener('click', event => {addRow()})
borrarFila.addEventListener('click', event => {remRow()})
cambiarTexto.addEventListener('click', event => {changeTest()})

function addRow(){
    let numColumns = prompt('Ingresa el numero de columnas')
    fila = document.createElement('tr')

    for(let i = 0; i < numColumns; i++){
        let columna = document.createElement('td')
        columna.setAttribute('id', 'c'+i+'f'+table.childNodes.length)
        parrafo = document.createTextNode("Parrafo" + (i+1))
        columna.appendChild(parrafo)
        fila.appendChild(columna)
    }
    table.appendChild(fila)
}

function remRow(){
    let numRow = prompt('Numero de la fila a eliminar')
    table.deleteRow(numRow-1)
    for(let i = numRow-1; i <= table.childNodes.length; i++){
        fila = table.childNodes[i]
        for(let j = 0; j < fila.childNodes.length; j++){
            columna = document.getElementById('c'+j+'f'+i)
            columna.id = 'c'+j+'f'+(i-1)
        }
    }
}

function changeTest(){
    let fila = prompt('Fila a modificar')
    let columna = prompt('Columna a modificar')
    let casilla = document.getElementById('c'+(columna-1)+'f'+(fila-1))
    casilla.innerHTML = texto.value
}