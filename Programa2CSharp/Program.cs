string nombre, dia;
int nac, edad;
uint dia_semana = 0;

Console.WriteLine("Escriba su nombre");
nombre = Console.ReadLine();    

while (dia_semana < 1 || dia_semana > 7) 
{
    try
    {
        Console.WriteLine("\nIngrese el dia de la semana en que nacio (Domingo inicia en 1)");
        dia_semana = Convert.ToUInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("\nError <--- Debe de escribir un numero entre el 1 y 7: " + ex.Message);
    }
}

switch (dia_semana)
{
    case 1: Console.WriteLine("\nSelecciono el dia Domingo");
        break;
    case 2: Console.WriteLine("\nSelecciono el dia Lunes");
        break;
    case 3:
            Console.WriteLine("\nSelecciono el dia Martes");
        break;
    case 4:
            Console.WriteLine("\nSelecciono el dia Miercoles");
        break;
    case 5:
            Console.WriteLine("\nSelecciono el dia Jueves");
        break;
    case 6:
            Console.WriteLine("\nSelecciono el dia Viernes");
        break;
    case 7:
            Console.WriteLine("\nSelecciono el dia Sabado");
        break;
};

Console.WriteLine("\n--------------Presione una tecla para continuar----------------");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Escriba su año de nacimiento: ");
nac = Convert.ToInt32(Console.ReadLine());

if ((nac % 2) == 0)
{
    Console.WriteLine("\nTu año de nacimiento es par :)");
}
else
{
    Console.WriteLine("\nTu año de nacimiento es impar :)");
}

String fecha = DateTime.Now.ToString("yyyy");
edad = Convert.ToInt32(fecha) - nac;

if (edad <= 17)
{
    Console.WriteLine("\n<---- Tienes " + edad + " Sos patojo frega todo lo que podas, deja recuerdo de todas tus travesuras");
}
else if(edad == 18 || edad == 19)
{
    Console.WriteLine("\n<---- Tienes " + edad + " Sos patojo con DPI pero centrate en tus metas");
}
else if(edad >= 20 && edad <= 29)
{
    Console.WriteLine("\n<---- Tienes " + edad + " Sos joven, disfruta y aprovecha tu juventud, no metas la pata aun, y se vale equivocarse");
}
else if(edad >= 30 && edad <= 60)
{
    Console.WriteLine("\n<---- Tienes " + edad + " Sos adulto disfruta tu vida profesional y tu vida personal");
}
else
{
    Console.WriteLine("\n<---- Tienes " + edad + " Sos adulto mayor cosecha lo que sembraste, no hay vuelta atrás");
}
