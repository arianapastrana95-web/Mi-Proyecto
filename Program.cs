using System;

System.Console.WriteLine("---- Ingreso de notas de Curso ----");
int x = 0;

while (x == 0)
{
    for (int i = 0; i < 3; i++)
    {
        System.Console.WriteLine("Ingrese Nota " + (i + 1) + ": ");
        int nota = int.Parse(System.Console.ReadLine());
    }

    System.Console.WriteLine("¿Necesita ingresar nuevo estudiante? (s/n): ");
    char estudiante = char.Parse(System.Console.ReadLine());

    if (estudiante == 's') x = 0;
    else x = 1;
}