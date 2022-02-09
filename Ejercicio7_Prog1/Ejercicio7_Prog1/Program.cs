string bienvenida = "Bienvenido querido usuario :)\n" +
    " ";
Console.WriteLine(bienvenida);

int opc;
Console.WriteLine("Menú de opciones :\n" +
    " \n" +
    "1. Comprobar si un numero es par\n" +
    "0. Salir del programa\n" +
    " " +
    "Ingrese una de las opciones:)\n" +
    " ");
opc = Convert.ToInt32(Console.ReadLine());

//variable
int a;

switch (opc)
{
    case 0:
        Console.WriteLine("Ha salido del programa con éxito\n" +
            "Hata la próxima!");
        break;

    case 1:
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
        break;

    default:
        Console.WriteLine("Opción inválida :(");
        break;
}
Console.ReadKey();