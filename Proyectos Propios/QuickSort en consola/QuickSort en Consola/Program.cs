// See https://aka.ms/new-console-template for more information
using System.Xml;
using System.Threading;

int longitud = 500000;
List<double> ListaPrincipal = new List<double>();

while (true)
{
    Menu();
}

void Menu()
{
    Console.WriteLine("Elige una opcion");
    Console.WriteLine("Crear lista = C");
    Console.WriteLine("Ordenar lista = O");
    Console.WriteLine("Comprobar lista = Check");
    Console.WriteLine("Ver lista = V");
    switch (Console.ReadLine())
    {
        case "C":
            btnCrear_Click();
            break;
        case "O":
            btnSort_Click(); 
            break;
        case "Check":
            btnComprobar_Click();
            break;
        case "V":
            btnShowList_Click();
            break;
        default: 
            Console.WriteLine("Opcion no valida");
            break;
    }
}

void btnCrear_Click()
{
    Random rand = new Random();
    for (int i = 0; i < longitud; i++)
    {
        ListaPrincipal.Add(rand.Next(0, 10000));
    }
    Console.WriteLine("Lista creada");
}

void btnShowList_Click()
{
    string salida = "";
    for (int i = 0; i < ListaPrincipal.Count(); i++)
    {
        salida += (ListaPrincipal[i] + ", ");
        if(i % 100 == 0)
        {
            Console.WriteLine(salida);
            salida = "";
        }
    }
    Console.WriteLine(salida);
}

void btnSort_Click()
{
    ListaPrincipal = Sort(ListaPrincipal);
    Console.WriteLine("Ordenado");
}

void btnComprobar_Click()
{
    bool check = true;
    for (int i = 0; i < ListaPrincipal.Count() - 1; i++)
    {
        if (ListaPrincipal[i + 1] < ListaPrincipal[i])
        {
            Console.WriteLine("Error numero" + ListaPrincipal[i - 1]);
            check = false;
            break;
        }
    }
    if (check) { Console.WriteLine("Correcto"); }
}

List<double> Sort(List<double> listaPrincipal)
{
    if (listaPrincipal.Count() <= 1)
    {
        return listaPrincipal;
    }

    int pivot = listaPrincipal.Count() / 2;
    double pivotValor = listaPrincipal[pivot];

    List<double> left = new List<double>();
    List<double> right = new List<double>();

    for (int i = 0; i < listaPrincipal.Count(); i++)
    {
        if (i == pivot)
        {
            continue;
        }
        if (listaPrincipal[i] >= listaPrincipal[pivot])
        {
            right.Add(listaPrincipal[i]);
        }
        else if (listaPrincipal[i] <= listaPrincipal[pivot])
        {
            left.Add(listaPrincipal[i]);
        }
    }

    left = Sort(left);
    right = Sort(right);

    left.Add(pivotValor);
    left.AddRange(right);

    return left;
}
