
function Ordenador(marca, modelo, ram, disco, pulgadas, fecha, ...accesorios){
    this.marca = isNaN(marca) ? marca : "no definida";
    this.modelo = isNaN(modelo) ? modelo : "no definido";
    this.ram = isNaN(ram) ? 16 : ram;
    this.disco = isNaN(disco) ? 256 : disco;
    this.pulgadas = isNaN(pulgadas) ? 15.6 : pulgadas;
    this.fecha = isNaN(Date.parse(fecha)) ? Date.now() : Date.parse(fecha);
    this.accesorios = accesorios;

    this.mostrarOrdenador = function(){
        let stringSalida =  'ORDENADOR: ' + this.marca + " " + this.modelo + '\n' +
                            'RAM: ' + this.ram + '\n' +
                            'DISCO: ' + this.disco + '\n' +
                            'PULGADAS: ' + this.pulgadas + '\n' +
                            'ALTA: ' + new Date(this.fecha).toLocaleString() + '\n'
        this.accesorios.forEach(accesorio => {
            stringSalida += '- ' + accesorio + '\n'            
        });
        console.log(stringSalida);
    };

    this.actualizarMarcaModelo = function(marca, modelo){
        this.marca = isNaN(marca) ? marca : "no definida";
        this.modelo = isNaN(modelo) ? modelo : "no definido";
    };

    this.actualizarRamDiscoPulgadas = function(ram, disco, pulgadas){
        this.ram = isNaN(ram) ? 16 : ram;
        this.disco = isNaN(disco) ? 256 : disco;
        this.pulgadas = isNaN(pulgadas) ? 15.6 : pulgadas;
    };

    this.actualizarFecha = function(fecha){
        this.fecha = isNaN(Date.parse(fecha)) ? Date.now() : Date.parse(fecha);
    };

    this.anyadirAccesorios = function(...accesorios){
        accesorios.forEach(accesorio => {
            if (!this.accesorios.includes(accesorio)){
                this.accesorios.push(accesorio);
            }
        });
    };

    this.borrarAccesorios = function(...accesorios){
        accesorios.forEach(accesorio => {
            if (this.accesorios.includes(accesorio)){
                this.accesorios.pop(accesorio);
            }
        });
    };
}

let pc1 = new Ordenador('lenovo', 'legion', 32, 256, 15.6, '2022-11-09', 'ratón', 'teclado');
let pc2 = new Ordenador('hp', 'omen', 32, 256, 15.6, '2022-11-09', 'ratón', 'teclado');
let pc3 = new Ordenador('acer', 'ferrari', 32, 256, 15.6, '2022-09-09', 'ratón', 'teclado');
let pc4 = new Ordenador('msi', 'modern', 32, 256, 15.6, '2022-08-09', 'ratón', 'teclado');

let arrayPc = [pc1, pc2, pc3, pc4];

arrayPc.forEach(pc =>{
    pc.mostrarOrdenador();

})

let arrayFechas = arrayPc.reduce((acc, pc) =>{
    let fecha = new Date(pc.fecha).toLocaleDateString();
    if (acc[fecha] == undefined){
        acc[fecha] = 1;
    }
    else {
        acc[fecha] += 1;
    }
    return acc;
}, {});

let stringSalida = "";
for (let fecha in arrayFechas){
    stringSalida += fecha + ": " + arrayFechas[fecha] + "\n";
}

console.log(stringSalida);