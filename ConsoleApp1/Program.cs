using ConsoleApp1;


ArbolBBP arbolEmpleados = new ArbolBBP();

int opcion;
do
{
    Console.WriteLine("\nMenu");
    Console.WriteLine("1- Agregar");
    Console.WriteLine("2- Listar InOrden por Codigo");
    Console.WriteLine("3- Listar PosOrden por Antiguedad");
    Console.WriteLine("4- Mayores de cierta antiguedad");
    Console.WriteLine("5- Penultimo");
    Console.WriteLine("9- Fin");
    Console.Write("Elige una opcion: ");
    opcion = int.Parse(Console.ReadLine()!);




    if (opcion == 1)
    {
        Console.Write("Codigo: ");
        int cod = int.Parse(Console.ReadLine()!);
        Console.Write("Nombre: ");
        string nom = Console.ReadLine()!;
        Console.Write("Antiguedad: ");
        int ant = int.Parse(Console.ReadLine()!);
        arbolEmpleados.Agrega(new Empleado(cod, nom, ant));
    }
    else if (opcion == 2)
    {
        arbolEmpleados.MuestraInCodigo();
    }
    else if (opcion == 3)
    {
        arbolEmpleados.MuestraPosAntiguedad();
    }
    else if (opcion == 4)
    {
        Console.Write("Antiguedad minima: ");
        int ant = int.Parse(Console.ReadLine()!);
        int cant = arbolEmpleados.MayoresA(ant);
        Console.WriteLine($"Empleados con mas de {ant} años: {cant}");
    }
    else if (opcion == 5)
    {
        Console.WriteLine(arbolEmpleados.Penultimo());
    }

} while (opcion != 9);
