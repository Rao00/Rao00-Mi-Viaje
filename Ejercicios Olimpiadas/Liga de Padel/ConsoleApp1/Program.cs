
using System.Diagnostics;
using System.Text;

Stopwatch tiempo = Stopwatch.StartNew();
tiempo.Start();

Dictionary<string, Dictionary<string, int>> clasificacionTotal = new Dictionary<string, Dictionary<string, int>>();
Dictionary<string, int> clasificacionCategoria = new Dictionary<string, int>();

ReadInput();

foreach (var clasificacionPorCategoria in clasificacionTotal)
{
    Console.WriteLine(clasificacionPorCategoria.Key);

    string parejaGanadora = String.Empty;
    int puntosPareja = 0;
    foreach (var parejasConPuntos in clasificacionPorCategoria.Value)
    {
        parejaGanadora = parejasConPuntos.Value > puntosPareja ? parejasConPuntos.Key : parejaGanadora;
        puntosPareja = parejasConPuntos.Value > puntosPareja ? parejasConPuntos.Value : puntosPareja;
    }
    clasificacionPorCategoria.Value.Remove(parejaGanadora);

    int puntosParejaSegunda = 0;
    foreach (var parejasConPuntos in clasificacionPorCategoria.Value)
    {
        puntosParejaSegunda = parejasConPuntos.Value > puntosParejaSegunda ? parejasConPuntos.Value : puntosParejaSegunda;
    }

    int difPuntosPareja = puntosPareja - puntosParejaSegunda;

    if (difPuntosPareja > 0)
        Console.WriteLine($"{parejaGanadora} {difPuntosPareja}\n");
    else
        Console.WriteLine("Empate\n");
}

tiempo.Stop();
Console.WriteLine(tiempo.ToString());

void ReadInput(string ruta = ".\\..\\..\\..\\Input.txt")
{
    StreamReader reader = new StreamReader(ruta);
    string linea = reader.ReadLine();
    string nombreCategoria = "";

    while (linea != null)
    {
        List<string> listaDePalabras = ReadWord(linea);

        if (linea == "FIN")
        {
            if (clasificacionTotal.ContainsKey(nombreCategoria))
                break;

            clasificacionTotal.Add(nombreCategoria, clasificacionCategoria);
            linea = reader.ReadLine();
            continue;
        }

        if (listaDePalabras.Count == 1)
        {
            nombreCategoria = linea;
            clasificacionCategoria = new Dictionary<string, int>();
            linea = reader.ReadLine();
            continue;
        }

        bool localGanador = (int.Parse(listaDePalabras[1]) > int.Parse(listaDePalabras[3]));

        for (int i = 0; i < listaDePalabras.Count; i += 2)
        {
            int puntosAGanar = 0;
            if ((localGanador && i == 0) || (!localGanador && i == 2))
                puntosAGanar = 2;
            if ((!localGanador && i == 0) || (localGanador && i == 2))
                puntosAGanar = 1;

            if (!clasificacionCategoria.ContainsKey(listaDePalabras[i]))
                clasificacionCategoria.Add(listaDePalabras[i], puntosAGanar);
            else
                clasificacionCategoria[listaDePalabras[i]] += puntosAGanar;
        }

        linea = reader.ReadLine();
    }
}

List<string> ReadWord(string linea)
{
    StringBuilder palabra = new StringBuilder();
    List<string> salida = new List<string>();

    for (int i = 0; i < linea.Length; i++)
    {
        if (linea[i] == ' ')
        {
            salida.Add(palabra.ToString());
            palabra.Clear();
            continue;
        }

        palabra.Append(linea[i].ToString());
    }
    salida.Add(palabra.ToString());

    return salida;
}