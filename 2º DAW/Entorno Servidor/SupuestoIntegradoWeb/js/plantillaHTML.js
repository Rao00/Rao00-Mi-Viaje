
async function CargarPlantilla(){
    let header = document.getElementsByTagName('headerPlantilla')[0];
    let footer = document.getElementsByTagName('footerPlantilla')[0];

    if (header) {
        header.innerHTML = await(await fetch('../master/headerMasterHTML.html')).text();
    }
    if (footer) {
        footer.innerHTML = await(await fetch('../master/footerMasterHTML.html')).text();
    }
}

async function CargarProductosEscaparate() {
    let escaparate = document.getElementsByTagName('articulosEscaparate')[0];
    if (escaparate){
        let plantillaProducto = await(await fetch('../master/productoEscaparate.html')).text();
        let datosProductos = await(await fetch('https://localhost:7200/api/productos')).json();
        // * (10 * pagina) pagina
        for (let i = 1; i < datosProductos.value.length; i++){
            let productoHTML = plantillaProducto;
            // let img = plantillaProducto.getElementById('img');
            productoHTML = productoHTML.replace('NOMBRE', datosProductos.value[i]['nombre']);
            productoHTML = productoHTML.replace('PRECIO', datosProductos.value[i]['precio']);
            escaparate.innerHTML += productoHTML;
        }
    }
}

async function ContarPaginasMax(){
    let datosProductos = await(await fetch('https://localhost:7200/api/productos')).json();
    return datosProductos.value.length;
}

CargarProductosEscaparate();
CargarPlantilla();