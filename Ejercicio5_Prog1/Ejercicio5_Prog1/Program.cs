//Nombre: Alexander Enrique Zelaya Sánchez, Ingeníeria en Sistemas, Cátedra de Programación I

//Variable "Saludo"
string saludo = "Bienvenido querido Usuario:)\n" +
    " ";
//Imprimir "Saludo"
Console.WriteLine(saludo);
//Variable "opc"´para opciones en el Switch Case
int opc;
//Menú de opciones
Console.WriteLine("Menú de opciones :\n" +
    "1. El valor de cada variable.\n" +
    "2. La suma  X + Y\n" +
    "3. La diferencia  X – Y\n" +
    "4. El producto  X * Y\n" +
    "5 .El cociente  X / Y\n" +
    "6. El resto  X % Y\n" +
    "7. La suma  N + M\n" +
    "8. La diferencia  N – M\n" +
    "9. El producto  N * M\n" +
    "10. El cociente  N / M\n" +
    "11. El resto  N % M\n" +
    "12. La suma X + N\n" +
    "13. El cociente Y / M\n" +
    "14. El resto Y % M\n" +
    "15. El doble de cada variable\n" +
    "16. La suma de todas las variables\n" +
    "17. El producto de todas las variables\n" +
    "0. Salir del programa\n" +
    " " +
    " Ingrese una de las opciones:)");
//almacenar el dato en la variable "opc" dictado en la consola convirtiendolo a Int
opc = Convert.ToInt32(Console.ReadLine());
//Variables
int x;
int y;
double n;
double m;
double resultado;
double resultado2;
double resultado3;
double resultado4;
//Switch Case
switch (opc)
{
    //Salir del programa
    case 0:
        Console.WriteLine("Ha salido del programa con éxito\n" +
            "Hata la próxima!");
        break;
    case 1:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"La variable X tiene un valor de: {x}\n" +
            $"la variable Y tiene un valor de: {y}");
        break;
    case 2:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        resultado = x + y;
        Console.WriteLine($"El resultado de la suma entre {x} y {y} es: {resultado}");
        break;
    case 3:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        resultado = x - y;
        Console.WriteLine($"El resultado de la resta entre {x} y {y} es: {resultado}");
        break;
    case 4:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        resultado = x * y;
        Console.WriteLine($"El resultado de la multiplicación entre {x} y {y} es: {resultado}");
        break;
    case 5:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        resultado = x / y;
        Console.WriteLine($"El resultado de la división entre {x} y {y} es: {resultado}");
        break;
    case 6:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        resultado = x % y;
        Console.WriteLine($"El resultado del resto entre {x} y {y} es: {resultado}");
        break;
    case 7:
        Console.WriteLine("Ingrese un número: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = n + m;
        Console.WriteLine($"El resultado de la suma entre {n} y {m} es: {resultado}");
        break;
    case 8:
        Console.WriteLine("Ingrese un número: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = n - m;
        Console.WriteLine($"El resultado de la resta entre {n} y {m} es: {resultado}");
        break;
    case 9:
        Console.WriteLine("Ingrese un número: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = n * m;
        Console.WriteLine($"El resultado de la multiplicación entre {n} y {m} es: {resultado}");
        break;
    case 10:
        Console.WriteLine("Ingrese un número: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = n / m;
        Console.WriteLine($"El resultado de la división entre {n} y {m} es: {resultado}");
        break;
    case 11:
        Console.WriteLine("Ingrese un número: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = n + m;
        Console.WriteLine($"El resultado del resto entre {n} y {m} es: {resultado}");
        break;
    case 12:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        n = Convert.ToDouble(Console.ReadLine());
        resultado = x + n;
        Console.WriteLine($"El resultado de la suma entre {x} y {n} es: {resultado}");
        break;
    case 13:
        Console.WriteLine("Ingrese un número: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = y / m;
        Console.WriteLine($"El resultado de la división entre {y} y {m} es: {resultado}");
        break;
    case 14:
        Console.WriteLine("Ingrese un número: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = y % m;
        Console.WriteLine($"El resultado del resto entre {y} y {m} es: {resultado}");
        break;
    case 15:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        resultado = x + x;

        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        resultado2 = y + y;

        Console.WriteLine("Ingrese otro número: ");
        n = Convert.ToDouble(Console.ReadLine());
        resultado3 = n + n;

        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToInt32(Console.ReadLine());
        resultado4 = m + m;

        Console.WriteLine($"El doble de {x} es: {resultado}\n" +
            $"El doble de {y} es: {resultado2}\n" +
            $"El doble de {n} es: {resultado3}\n" +
            $"El doble de {m} es: {resultado4}");
        break;
    case 16:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = x + y + n + m;
        Console.WriteLine("El resultado de la suma\n" +
            $"entre {x}, {y}, {n} y {m} es: {resultado}");
        break;
    case 17:
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        m = Convert.ToDouble(Console.ReadLine());
        resultado = x * y * n * m;
        Console.WriteLine("El resultado de la multiplicación\n" +
            $"entre {x}, {y}, {n} y {m} es: {resultado}");
        break;
    default: Console.WriteLine("Opción Invalida");
        break;
}
Console.ReadKey();