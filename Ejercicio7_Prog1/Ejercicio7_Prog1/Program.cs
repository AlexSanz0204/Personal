//Hecho por Alexander Enrique Zelaya Sánchez, Ingeniería En Sistemas, Cátedra Programación I

string bienvenida = "Bienvenido querido usuario :)\n" +
    " ";
Console.WriteLine(bienvenida);

//variable
int a;

while (true)
{
    int opc;
    Console.WriteLine("Menú de opciones :\n" +
        " \n" +
        "1. Comprobar si un numero es par\n" +
        "0. Salir del programa\n" +
        " " +
        "Ingrese una de las opciones:)\n" +
        " ");
    opc = Convert.ToInt32(Console.ReadLine());

    if (opc == 0)
    {
        Console.WriteLine("Ha salido del programa con éxito\n" +
            "Hasta la próxima!");
        break;
    }

    else
        if (opc == 1)
    {
        Console.WriteLine("Ingrese un número: ");
        a = Convert.ToInt32(Console.ReadLine());
        
        if ((a % 2) == 0)
        {
            Console.WriteLine(" \n" +
                $"el número que usted ingresó ({a}) es un número par :)");
        }
        else
        {
            Console.WriteLine(" \n" +
                $"el número que usted ingresó ({a}) es un número impar :(");
        }
    }

    else 
        if (opc >= 2)
    {
        Console.WriteLine("Opción invalida:(\n" +
            "Ingrese otra opción" +
            " \n" +
            "----------------");
    }
}
Console.ReadKey();