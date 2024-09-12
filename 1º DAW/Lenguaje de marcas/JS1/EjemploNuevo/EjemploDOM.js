function iniciar()
{
    // var nodoTitle = document.createElement('title')
    // var txtTitle = document.createTextNode('Pagina con JS')
    // nodoTitle.appendChild(txtTitle)
    // document.head.appendChild(nodoTitle)

    // var nodo = document.getElementsByTagName('title')
    // nodo[0].remove()

    var nodoH1 = document.createElement('h1')
    nodoH1.innerHTML = '<h1>'+'Puzlecito'+'</h1>'
    nodoH1.setAttribute('style', 'font-style: italic')
    var tagP = document.createElement('p')
    tagP.innerHTML = '<p>'+'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ut ipsum adipisci maiores accusantium provident ab eaque dolor hic doloribus nostrum, et corporis ex totam at velit, id explicabo magni a!'+'</p>'
    tagP.setAttribute('style', 'color:blue')
    document.body.appendChild(nodoH1)
    document.body.appendChild(tagP)

    document.getElementById('changeImg').addEventListener('click', function(){
        let ruta = document.getElementById('harold')    
        if(ruta.alt == 'harold1')
        {
            document.getElementById('harold').src = './harold2.jpg'
            document.getElementById('harold').alt = 'harold2'
        }
        else if(ruta.alt == 'harold2')
        {
            document.getElementById('harold').src = './harold.jpg'
            document.getElementById('harold').alt = 'harold1'
        }
    })
}