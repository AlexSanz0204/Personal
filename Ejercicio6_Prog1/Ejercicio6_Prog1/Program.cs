//Hecho por Alexander Enrique Zelaya Sánchez, Ingeniería en Sistemas, Cátedra Programación I

//Variables
int a;
int b;
int c;
int d;
int resultado;
int resultado2;
int resultado3;
int resultado4;

string bienvenida = "Bienvenido querido usuario :)";
Console.WriteLine(bienvenida);



while (true)
{
    int opc;
    Console.WriteLine("Menú de opciones :\n" +
    " \n" +
    "1. El valor de cada variable.\n" +
    "0. Salir del programa\n" +
    " " +
    "Ingrese una de las opciones:)\n" +
    " ");
    opc = Convert.ToInt32(Console.ReadLine());

    if (opc == 0)
    {
    Console.WriteLine("Ha salido del programa con éxito\n" +
                "Hata la próxima!" +
                " \n" +
                "----------------");
        break;
    }

    else

        if (opc == 1)
    {
        Console.WriteLine("Ingrese el valor de A");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de B");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de C");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de D");
        d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" ");

         Console.WriteLine("Los valores iniciales son:\n" +
             $"A = {a}\n" +
             $"B = {b}\n" +
             $"C = {c}\n" +
             $"D = {d}" +
             " \n" +
             "----------------");

        resultado = b = c;
        resultado2 = c = a;
        resultado3 = a = d;
        resultado4 = b = d;

        Console.WriteLine(" ");

        Console.WriteLine("Los valores Finales son:\n" +
        $"A = {resultado3} porque A tome el valor de D\n" +
        $"B = {resultado} porque B toma el valor de C\n" +
        $"C = {resultado2} porque C tome el valor de A\n" +
        $"D = {resultado4} porque D tome el valor de B" +
        " \n" +
        "----------------");
    }

    else

        if (opc >= 2)
    {
        Console.WriteLine("Opción Invalida :(" +
            "Vuelve a intentarlo" +
            " \n" +
            "----------------");
    }
}
Console.ReadKey();