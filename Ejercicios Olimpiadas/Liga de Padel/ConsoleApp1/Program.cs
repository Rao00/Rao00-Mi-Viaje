
using ConsoleApp1;
using System.Text;

List<Categoria> ListaGanadores = new List<Categoria>();

ReadInput();

foreach (Categoria ganadoresCat in ListaGanadores)
{
    Console.WriteLine(ganadoresCat.Name);

    Dictionary<string, int> ganadores = new Dictionary<string, int>{ {" ",0} };

    for (int i = 0; i < ganadoresCat.List.Count; i++)
    {
        string pareja = ganadoresCat.List[i];
        if (ganadores.ContainsKey(pareja))
        {
            ganadores[pareja] += 1;
        }
        else
        { 
            ganadores.Add(pareja, 1);
        }
    }

    for (int i = 0; i < ganadores.Count; i++)
    {

    }

    if (parejaGanadora != " ")
        Console.WriteLine($"Ganador = {parejaGanadora} {ganadores[parejaGanadora]}");
}

Console.ReadLine();

void ReadInput(string ruta = ".\\..\\..\\..\\Input.txt")
{
    StreamReader reader = new StreamReader(ruta);
    string linea = reader.ReadLine();

continueReading:
    Categoria categoria = new Categoria();
    while (linea != null)
    {
        if (linea == "FIN")
        {
            linea = reader.ReadLine();
            break;
        }
            
        List<string> palabras = ReadWord(linea);

        if (palabras.Count() == 1)
        {
            categoria.Name = palabras[0];
            linea = reader.ReadLine();
            continue;
        }
        
        if (int.Parse(palabras[1]) > int.Parse(palabras[3]))
            categoria.AddPartido(palabras[0]);
        else
            categoria.AddPartido(palabras[2]);

        linea = reader.ReadLine();
    }
    ListaGanadores.Add(categoria);

    if (linea != null)
    {
        goto continueReading;
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