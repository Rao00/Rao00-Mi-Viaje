
async function CargarPlantilla(){
    let header = document.getElementsByTagName('header')[0];
    let footer = document.getElementsByTagName('footer')[0];

    if (header) {
        header.innerHTML = await(await fetch('../master/headerMasterHTML.html')).text();
        header.classList = ('navbar navbar-expand-lg navbar-dark');
    }
    if (footer) {
        footer.innerHTML = await(await fetch('../master/footerMasterHTML.html')).text();
        footer.classList = ('footer py-4');
    }
}

CargarPlantilla();